using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Models;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class TestPresenter : BasePresenter<ITestView, TestDataModel>
    {
        private readonly TestContext _context;
        private Test _currentTest;
        private Question _currentQuestion;
        private int _counter;
        private TestDataModel _testDataModel;
        private List<Variant> _currentVariants;
        private readonly IDictionary<Question, IList<IAnswerItem>> _resultItems;
        private const int CountOfVariantsOnForm = 5;

        public TestPresenter(IApplicationController controller, ITestView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);
            View.LoadForm += LoadTestForm;
            View.NextQuestionChoosed += NextQuestionChoosed;
            View.ContextDispose += ContextDispose;
            View.FinishingTest += FinishingTest;
            _resultItems = new Dictionary<Question, IList<IAnswerItem>>();
        }

        private void FinishingTest()
        {
            GetQuestionAnswer();

            var calculationStrategy = new BaseCalculationStrategy(_currentTest.ResultConfig, _currentTest.TestConfig,
                _resultItems);
            var result = calculationStrategy.GetResult();
            result.StudentId = _testDataModel.StudentId;

            var unitOfWork = new UnitOfWork(_context);
            var resultService = new ResultService(unitOfWork, unitOfWork);
            resultService.AddResult(result);
        }

        private void ContextDispose()
        {
            _context.Dispose();
        }

        private void NextQuestionChoosed()
        {
            GetQuestionAnswer();
            if (_currentTest.TestConfig.NumberOfQuestions - 2 == _counter)
            {
                View.ShowFinishButton();
            }

            _currentQuestion = _currentTest.Questions.ElementAt(++_counter);
            _currentVariants = _currentQuestion.Variants;

            SetQuestionOnView();
        }

        private void GetQuestionAnswer()
        {
            var questionAnswers = View.GetQuestionAnswers();
            _resultItems.Add(_currentQuestion, questionAnswers);
        }

        private void LoadTestForm()
        {
            var unitOfWork = new UnitOfWork(_context);
            var testService = new TestService(unitOfWork, unitOfWork);

            _currentTest = testService.GetTestSingleton();
            _currentQuestion = _currentTest.Questions.First();
            _currentVariants = _currentQuestion.Variants;

            SetQuestionOnView();

            unitOfWork.Commit();
        }

        private void SetQuestionOnView()
        {
            View.SetQuestionCounter(_counter + 1);
            View.SetQuestionText(_currentQuestion.Description);
            var randomSequence = GenerateRandomSequence(_currentVariants.Count);
            for (var i = 1; i <= CountOfVariantsOnForm; i++)
            {
                if (i <= _currentVariants.Count)
                {
                    var variant = _currentVariants.ElementAt(randomSequence[i - 1]);
                    View.SetVariantCheckbox(i, variant.Id);
                    View.SetVariantCheckboxVisibility(i, true);
                    View.SetVariantTextbox(i, variant.Description);
                }
                else
                {
                    View.SetVariantCheckboxVisibility(i, false);
                    View.SetVariantTextboxVisibility(i, false);
                }
            }
        }

        private List<int> GenerateRandomSequence(int count)
        {
            var rnd = new Random();
            var sequence = Enumerable.Range(0, count).OrderBy(n => rnd.Next());
            var result = sequence.ToList();
            return result;
        }

        public override void Run(TestDataModel arg)
        {
            _testDataModel = arg;
            View.Show();
        }
    }
}