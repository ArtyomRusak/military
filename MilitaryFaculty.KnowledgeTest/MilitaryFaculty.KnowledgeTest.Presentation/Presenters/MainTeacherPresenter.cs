using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class MainTeacherPresenter : BasePresenter<IMainTeacherView>
    {
        private TestContext _context;
        private IList<Question> _questionsToSelect;
        private IList<Question> _selectedQuestions;

        public MainTeacherPresenter(IApplicationController controller, IMainTeacherView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);
            
            View.AddQuestion += OpenQuestionForm;
            View.TestButton += TestQuestionForm;
            View.ContextDispose += Close;
            View.LoadQuestions += LoadAllQuestions;
            View.OpenEditQuestionForm += OpenQuestionFormForEdit;
        }

        private void OpenQuestionFormForEdit(Question question)
        {
            Controller.Run<AddEditQuestionPresenter, Question>(question);

            UpdateGrid();
        }

        private void LoadAllQuestions()
        {
            var unitOfWork = new UnitOfWork(_context);
            var questionService = new QuestionService(unitOfWork, unitOfWork);
            _questionsToSelect = questionService.GetAllNonBindedQuestions();
            _selectedQuestions = questionService.GetAllBindedQuestions();
            View.SetDatasourcesToNull();
            View.SetNonBindedQuestions(_questionsToSelect);
            View.SetBindedQuestions(_selectedQuestions);

            unitOfWork.Commit();
        }

        public void TestQuestionForm()
        {
            //_context = new TestContext(Resources.ConnectionString);
            var unitOfWork = new UnitOfWork(_context);
            var questionService = new QuestionService(unitOfWork, unitOfWork);
            var questions = questionService.GetAllQuestions();
            var question = questions.Last();
            Controller.Run<AddEditQuestionPresenter, Question>(question);
            unitOfWork.Commit();
        }

        public void OpenQuestionForm()
        {
            Controller.Run<AddEditQuestionPresenter>();

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            if (_context != null)
            {
                _context = new TestContext(Resources.ConnectionString);
            }

            //Move this functionality to function.
            //var unitOfWork = new UnitOfWork(_context);
            //var questionService = new QuestionService(unitOfWork, unitOfWork);
            //var questions = questionService.GetAllQuestions();
            //View.SetDatasourcesToNull();
            //View.SetBindedQuestions(questions);
            //unitOfWork.Commit();


            LoadAllQuestions();
        }

        public void Close()
        {
            _context.Dispose();
        }
    }
}
