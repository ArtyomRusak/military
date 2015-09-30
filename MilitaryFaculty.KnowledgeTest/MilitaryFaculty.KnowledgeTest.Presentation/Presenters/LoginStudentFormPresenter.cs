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
    public class LoginStudentFormPresenter : BasePresenter<ILoginStudentView>
    {
        private TestContext _context;

        public LoginStudentFormPresenter(IApplicationController controller, ILoginStudentView view)
            : base(controller, view)
        {
            _context = new TestContext(Resources.ConnectionString);

            View.AccessTest += AccessTest;
            View.CloseFormAndDisposeContext += CloseFormAndDisposeContext;
        }

        private void CloseFormAndDisposeContext()
        {
            _context.Dispose();
        }

        private void AccessTest()
        {
            var studentData = View.GetStudentFormData();
            if (this.ValidateStudentData(studentData))
            {
                var unitOfWork = new UnitOfWork(_context);
                var studentService = new StudentService(unitOfWork, unitOfWork);

                var student = studentService.GetStudent(studentData);
                if (student != null)
                {
                    unitOfWork.Commit();
                    this.Controller.Run<TestPresenter, TestDataModel>(
                        new TestDataModel
                        {
                            StudentId = student.Id
                        });
                    View.Close();
                }
                else
                {

                }
            }
            else
            {
                View.ShowMessage("Введите имя, фамилию и группу!", "Предупреждение");
            }
        }

        private bool ValidateStudentData(Student studentData)
        {
            if (string.IsNullOrEmpty(studentData.Name) == false)
            {
                return false;
            }

            if (string.IsNullOrEmpty(studentData.Surname) == false)
            {
                return false;
            }

            if (studentData.Platoon / 100000 < 1)
            {
                return false;
            }

            return true;
        }
    }
}