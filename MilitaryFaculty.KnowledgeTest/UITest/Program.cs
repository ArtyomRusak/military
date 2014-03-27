using System;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Presentation;
using MilitaryFaculty.KnowledgeTest.Presentation.Presenters;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace UITest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new AutofacInjectAdapter())
                .RegisterView<ILoginView, LoginForm>()
<<<<<<< HEAD
                .RegisterView<IMainTeacherView, MainTeacherForm>()
                .RegisterView<IAddQuestionView, AddQuestionForm>()
                .RegisterService<LoginPresenter>()
                .RegisterService<MainTeacherPresenter>()
                .RegisterService<AddQuestionPresenter>()
=======
                .RegisterService<LoginPresenter>()
>>>>>>> 1210192a112bdd229830e2e4517a2f04ce0f2f8a
                .RegisterInstance(new ApplicationContext())
                .DoneBuilding();

            controller.Run<LoginPresenter>();
        }
    }
}
