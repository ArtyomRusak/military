using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class AddQuestionPresenter : BasePresenter<IAddQuestionView>
    {
        private const string FailedDescription = "Введите название вопроса!";
        private const string FailedVariants = "Введите варианты ответов!";
        private const string SuccessfullyAdded = "Успешно добавлен!";

        private readonly TestContext _context;

        public AddQuestionPresenter(IApplicationController controller, IAddQuestionView view) : base(controller, view)
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
                View.ShowError(FailedDescription);
            }
            var variants = View.GetVariants;
            if (variants == null)
            {
                View.ShowError(FailedVariants);
            }

            var unitOfWork = new UnitOfWork(_context);
            var questionService = new QuestionService(unitOfWork, unitOfWork);
            var variantService = new VariantService(unitOfWork, unitOfWork);
            var question = questionService.AddQuestion(description);
            foreach (var variant in variants)
            {
                variantService.AddVariantToQuestion(variant.Key, variant.Value, question.Id);
            }

            unitOfWork.Commit();
            View.ShowError(SuccessfullyAdded);
        }

        public void Close()
        {
            _context.Dispose();
        }
    }
}
