using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
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
            //_context = new TestContext(Resources.ConnectionString);

            View.AddQuestion += CreateQuestionForm;
        }

        public void CreateQuestionForm()
        {
            Controller.Run<AddQuestionPresenter>();
        }

        public void Close()
        {
            
        }
    }
}
