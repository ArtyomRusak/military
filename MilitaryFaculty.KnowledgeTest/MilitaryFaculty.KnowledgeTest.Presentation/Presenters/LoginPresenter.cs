using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private IMembershipService _membershipService;
        private readonly TestContext _context;
        private const string WrongPassword = "Wrong password entered!";

        public LoginPresenter(IApplicationController controller, ILoginView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);

            View.LoginAsTeacher += () => LoginAsTeaher(View.Password);
            View.LoginAsStudent += LoginAsStudent;
            View.ContextDisposed += Close;
        }

        public void LoginAsTeaher(string password)
        {
            var unitOfWork = new UnitOfWork(_context);
            _membershipService = new MembershipService(unitOfWork, unitOfWork);

            if (_membershipService.LoginAsTeacher(password))
            {
                //TODO: Go to main form
                View.ShowError("Good");
                unitOfWork.Commit();
            }
            else
            {
                unitOfWork.Commit();
                View.ShowError(WrongPassword);
            }
        }

        public void LoginAsStudent()
        {
            View.ShowError("Got to student form");
        }

        public void Close()
        {
            _context.Dispose();
        }
    }
}
