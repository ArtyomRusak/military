using System;
using System.Collections.Generic;
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
        private readonly Test _singletonTest;
        private IList<Question> _questionsToSelect;
        private IList<Question> _selectedQuestions;

        public MainTeacherPresenter(IApplicationController controller, IMainTeacherView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);
            var unitOfWork = new UnitOfWork(_context);
            var testService = new TestService(unitOfWork, unitOfWork);
            _singletonTest = testService.GetTestSingleton();
            unitOfWork.Commit();

            View.AddQuestion += OpenQuestionForm;
            View.SaveChangesToTest += SaveChangesToTest;
            View.ContextDispose += ContextDispose;
            View.LoadQuestions += LoadAllQuestions;
            View.OpenEditQuestionForm += OpenQuestionFormForEdit;
            View.AddQuestionToTest += AddQuestionToTest;
            View.RemoveQuestionFromTest += RemoveQuestionFromTest;
            View.CloseFromDisposeContextAndOpenLoginForm += ViewOnCloseFromDisposeContextAndOpenLoginForm;
        }

        private void ViewOnCloseFromDisposeContextAndOpenLoginForm()
        {
            Controller.Run<LoginPresenter, bool>(false);
            ContextDispose();
        }

        private void RemoveQuestionFromTest()
        {
            var question = View.GetSelectedRowFromBindedQuestions();
            _singletonTest.Questions.Remove(question);

            _selectedQuestions.Remove(question);
            _questionsToSelect.Add(question);
            View.SetDatasourcesToNull();
            View.SetBindedQuestions(_selectedQuestions);
            View.SetNonBindedQuestions(_questionsToSelect);
        }

        private void AddQuestionToTest()
        {
            var question = View.GetSelectedRowFromNonBindedQuestions();
            _singletonTest.Questions.Add(question);

            _selectedQuestions.Add(question);
            _questionsToSelect.Remove(question);
            View.SetDatasourcesToNull();
            View.SetBindedQuestions(_selectedQuestions);
            View.SetNonBindedQuestions(_questionsToSelect);

            //LoadAllQuestions();
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

        public void SaveChangesToTest()
        {
            if (View.ViewQuestionToConfirm())
            {
                try
                {
                    if (_singletonTest.Questions.Count > _singletonTest.TestConfig.NumberOfQuestions)
                    {
                        View.ShowMessage(
                            String.Format(
                                "Вы превысили допустимое количество вопросов. Измените конфигурацию для теста. Доступное количество - {0}",
                                _singletonTest.TestConfig.NumberOfQuestions), "Предупреждение");
                        return;
                    }

                    _context.SaveChanges();
                    View.ShowMessage("Сохранение прошло успешно.", string.Empty);
                }
                catch (Exception e)
                {
                    View.ShowMessage("При сохранении возникла ошибка.", string.Empty);
                }   
            }
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

            LoadAllQuestions();
        }

        public void ContextDispose()
        {
            _context.Dispose();
        }
    }
}
