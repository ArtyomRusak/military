using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using AR.EPAM.Infrastructure.Guard;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Services.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class MembershipService : IService
    {
        #region [Private members]

        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        #endregion


        #region [Ctor's]

        public MembershipService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        #endregion

        #region [MembershipService's members]

        public Student AddStudent(string name, string surname, int platoon)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            var student = GetStudent(name, surname, platoon);
            if (student != null)
            {
                throw new MembershipServiceException("Student exist.");
            }

            student = new Student() {Id = Guid.NewGuid(), Name = name, Surname = surname, Platoon = platoon};
            studentRepository.Add(student);
            return student;
        }

        public Student GetStudent(string name, string surname, int platoon)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                var student = studentRepository.Find(e => e.Name == name && e.Surname == surname && e.Platoon == platoon);
                return student;
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        }

        public Student GetStudent(Guid id)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                var student = studentRepository.GetEntityById(id);
                return student;
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        }

        public void UpdateStudent(Student student)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                studentRepository.Update(student);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        }

        public void RemoveStudent(Guid studentId)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                var student = GetStudent(studentId);
                studentRepository.Remove(student);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        }

        public void SetResult(Student student, int result)
        {
            Guard.AgainstNullReference(student, "student");

            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            student.SetResult(result);
            UpdateStudent(student);
        }

        #endregion

    }
}
