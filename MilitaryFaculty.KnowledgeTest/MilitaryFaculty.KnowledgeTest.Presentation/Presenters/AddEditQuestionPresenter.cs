using System;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class AddEditQuestionPresenter : BasePresenter<IAddEditQuestionView, Question>
    {
        private const string FailedDescription = "Введите название вопроса!";
        private const string FailedVariants = "Введите варианты ответов!Варианты ответов не должны совпадать!";
        private const string SuccessfullyAdded = "Успешно добавлен!";
        private const string ExceptionMessage = "Что-то пошло не так, попробуйте ещё раз!";
        private const string SuccessfullyUpdated = "Успешно обновлён!";

        private readonly TestContext _context;
        private Question _question;

        public AddEditQuestionPresenter(IApplicationController controller, IAddEditQuestionView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);

            View.ContextDispose += Close;
            View.AddQuestion += AddQuestion;
            View.UpdateQuestion += UpdateQuestion;
        }

        private void AddQuestion()
        {
            var description = View.GetDescription;
            if (description == "")
            {
                View.ShowMessage(FailedDescription);
                return;
            }
            var variants = View.GetVariants(false);
            if (variants == null)
            {
                View.ShowMessage(FailedVariants);
                return;
            }

            var unitOfWork = new UnitOfWork(_context);
            var questionService = new QuestionService(unitOfWork, unitOfWork);
            var variantService = new VariantService(unitOfWork, unitOfWork);

            var question = questionService.AddQuestion(description);
            foreach (var variant in variants)
            {
                //TODO: Do this with viewModel.
                var propertyInfo = variant.Value.GetType().GetProperty("IsRight");
                var isRight = propertyInfo.GetValue(variant.Value);
                variantService.AddVariantToQuestion(variant.Key, (bool)isRight, question.Id);
            }

            try
            {
                unitOfWork.Commit();
            }
            catch (Exception e)
            {
                View.ShowMessage(ExceptionMessage);
                return;
            }
            View.ShowMessage(SuccessfullyAdded);
            View.Close();
        }

        private void UpdateQuestion()
        {
            var questionId = View.GetQuestionId;
            var description = View.GetDescription;
            if (description == "")
            {
                View.ShowMessage(FailedDescription);
                return;
            }
            var variants = View.GetVariants(true);
            if (variants == null)
            {
                View.ShowMessage(FailedVariants);
                return;
            }

            var unitOfWork = new UnitOfWork(_context);
            var questionService = new QuestionService(unitOfWork, unitOfWork);
            var variantService = new VariantService(unitOfWork, unitOfWork);

            var question = questionService.GetQuestionById(questionId);
            questionService.UpdateQuestion(question.Id, description);
            foreach (var variant in variants)
            {
                //TODO: Do this with viewModel.
                var propertyInfoForIsRight = variant.Value.GetType().GetProperty("IsRight");
                var propertyInfoForVariantId = variant.Value.GetType().GetProperty("VariantId");
                var isRight = (bool)propertyInfoForIsRight.GetValue(variant.Value);
                var variantId = (int)propertyInfoForVariantId.GetValue(variant.Value);
                if (variantId != 0)
                {
                    var variantById = variantService.GetVariantById(variantId);
                    variantById.Description = variant.Key;
                    variantById.IsRight = isRight;
                    variantService.UpdateVariant(variantById);
                }
                else
                {
                    variantService.AddVariantToQuestion(variant.Key, isRight, question.Id);
                }
            }
            var newCount = variants.Count;
            var originalCount = question.Variants.Count;
            if (newCount < originalCount)
            {
                for (var i = newCount; i < originalCount; i++)
                {
                    var variant = question.Variants.Last();
                    variantService.RemoveVariant(variant);
                }
            }

            try
            {
                unitOfWork.Commit();
            }
            catch (Exception e)
            {
                View.ShowMessage(ExceptionMessage);
                return;
            }
            View.ShowMessage(SuccessfullyUpdated);
            View.Close();
        }

        public void Close()
        {
            _context.Dispose();
        }

        public override void Run(Question arg)
        {
            _question = arg;
            View.SetValues(_question);
            View.Show();
        }
    }
}
