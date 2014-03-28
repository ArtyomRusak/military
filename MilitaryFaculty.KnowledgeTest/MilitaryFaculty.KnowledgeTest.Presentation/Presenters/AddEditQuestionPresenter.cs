using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private readonly TestContext _context;
        private Question _question;

        public AddEditQuestionPresenter(IApplicationController controller, IAddEditQuestionView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);

            View.ContextDispose += Close;
            View.AddQuestion += AddQuestion;
        }

        private void AddQuestion()
        {
            var description = View.GetDescription;
            if (description == "")
            {
                View.ShowMessage(FailedDescription);
                return;
            }
            var variants = View.GetVariants;
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
                variantService.AddVariantToQuestion(variant.Key, variant.Value, question.Id);
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
