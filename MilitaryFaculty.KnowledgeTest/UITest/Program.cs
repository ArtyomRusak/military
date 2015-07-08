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
                .RegisterView<IMainTeacherView, MainTeacherForm>()
                .RegisterView<IAddEditQuestionView, AddEditEditQuestionForm>()
                .RegisterService<LoginPresenter>()
                .RegisterService<MainTeacherPresenter>()
                .RegisterService<AddEditQuestionPresenter>()
                .RegisterInstance(new ApplicationContext())
                .DoneBuilding();

            controller.Run<LoginPresenter, bool>(true);
        }
    }
}
