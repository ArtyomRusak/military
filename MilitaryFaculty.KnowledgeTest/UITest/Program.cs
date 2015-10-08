using System;
using System.IO;
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

            AppDomain.CurrentDomain.SetData("DataDirectory", Path.GetDirectoryName(Application.ExecutablePath));

            var controller = new ApplicationController(new AutofacInjectAdapter())
                .RegisterView<ILoginView, LoginForm>()
                .RegisterView<IMainTeacherView, MainTeacherForm>()
                .RegisterView<IAddEditQuestionView, AddEditQuestionForm>()
                .RegisterView<ILoginStudentView, LoginStudentForm>()
                .RegisterView<ITestView, TestForm>()
                .RegisterService<LoginPresenter>()
                .RegisterService<MainTeacherPresenter>()
                .RegisterService<AddEditQuestionPresenter>()
                .RegisterService<TestPresenter>()
                .RegisterService<StudentFormPresenter>()
                .RegisterInstance(new ApplicationContext())
                .DoneBuilding();

            controller.Run<LoginPresenter, bool>(true);
        }
    }
}