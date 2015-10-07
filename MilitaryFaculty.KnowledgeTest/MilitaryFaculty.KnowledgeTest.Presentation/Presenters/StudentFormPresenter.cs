using System;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.ControllerandContainer;
using MilitaryFaculty.KnowledgeTest.Presentation.Models;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using MilitaryFaculty.KnowledgeTest.Services;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Presenters
{
    public class StudentFormPresenter : BasePresenter<ILoginStudentView>
    {
        private readonly TestContext _context;

        public StudentFormPresenter(IApplicationController controller, ILoginStudentView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);

            View.StartTest += StartTest;
            View.ContextDispose += ContextDispose;
        }

        private void ContextDispose()
        {
            _context.Dispose();
        }

        private void StartTest()
        {
            var studentData = View.GetStudentData();
            if (ValidateStudentData(studentData))
            {
                var unitOfWork = new UnitOfWork(_context);
                var studentService = new StudentService(unitOfWork, unitOfWork);
                var student = studentService.GetStudent(studentData);
                if (student != null)
                {
                    unitOfWork.Commit();
                    View.Close();
                    Controller.Run<TestPresenter, TestDataModel>(new TestDataModel { StudentId = student.Id });
                }
                else
                {
                    student = studentService.AddStudent(studentData);
                    unitOfWork.Commit();
                    Controller.Run<TestPresenter, TestDataModel>(new TestDataModel { StudentId = student.Id });
                }
            }
        }

        private bool ValidateStudentData(Student studentData)
        {
            if (String.IsNullOrEmpty(studentData.Name))
            {
                View.ShowMessage("Введите имя!", string.Empty);
                return false;
            }

            if (String.IsNullOrEmpty(studentData.Surname))
            {
                View.ShowMessage("Введите фамилию!", string.Empty);
                return false;
            }

            if (studentData.Platoon <= 0)
            {
                View.ShowMessage("Введите корректный номер группы!", string.Empty);
                return false;
            }

            return true;
        }
    }
}