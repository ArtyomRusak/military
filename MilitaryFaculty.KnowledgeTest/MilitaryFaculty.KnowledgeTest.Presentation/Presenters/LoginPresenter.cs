using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.PresenterInterfaces;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>, IPresenter<bool>
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
                Controller.Run<MainTeacherPresenter>();
                unitOfWork.Commit();
                View.Close();
            }
            else
            {
                unitOfWork.Commit();
                View.ShowMessage(WrongPassword, string.Empty);
            }
        }

        public void LoginAsStudent()
        {
            View.ShowMessage("Go to student form", string.Empty);
        }

        public void Close()
        {
            _context.Dispose();
        }

        public void Run(bool arg)
        {
            View.IsStartPoint = arg;
            View.Show();
        }
    }
}
