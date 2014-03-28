using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class MainTeacherPresenter : BasePresenter<IMainTeacherView>
    {
        private readonly TestContext _context;

        public MainTeacherPresenter(IApplicationController controller, IMainTeacherView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);

            View.AddQuestion += CreateQuestionForm;
            View.TestButton += TestQuestionForm;
            View.ContextDispose += Close;
        }

        public void TestQuestionForm()
        {
            var questions = _context.Questions.ToList();
            var question = questions.Last();
            Controller.Run<AddEditQuestionPresenter, Question>(question);
        }

        public void CreateQuestionForm()
        {
            Controller.Run<AddEditQuestionPresenter>();
        }

        public void Close()
        {
            _context.Dispose();
        }
    }
}
