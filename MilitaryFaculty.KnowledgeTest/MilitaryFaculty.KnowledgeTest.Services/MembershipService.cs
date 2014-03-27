using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Infrastructure;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class MembershipService : IMembershipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public MembershipService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public Student AddStudent(string name, string surname, int platoon)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            var student = GetStudent(name, surname, platoon);
            if (student != null)
            {
                throw new MembershipServiceException("Student exist.");
            }

            student = new Student { Name = name, Surname = surname, Platoon = platoon };
            studentRepository.Add(student);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception e)
            {
                throw new ServiceException(e);
            }

            return student;
        }

        public Student GetStudent(string name, string surname, int platoon)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                return studentRepository.Find(e => e.Name == name && e.Surname == surname && e.Platoon == platoon);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        }

        public Student GetStudentById(int studentId)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                return studentRepository.GetEntityById(studentId);
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

        public void RemoveStudent(Student student)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();
            try
            {
                studentRepository.Remove(student);
            }
            catch (Exception e)
            {
                throw new MembershipServiceException(e.Message);
            }
        }

        public void SetResult(int studentId, double mark)
        {
            var resultRepository = _factoryOfRepositries.GetResultRepository();

            var student = GetStudentById(studentId);
            var result = new Result { Mark = mark, Date = DateTime.Now, StudentId = student.Id };
            resultRepository.Add(result);

            UpdateStudent(student);
        }

        public List<Result> GetResultsOfStudent(int studentId)
        {
            var student = GetStudentById(studentId);
            return student.Results.ToList();
        }

        public bool LoginAsTeacher(string password)
        {
            var securityRepository = _factoryOfRepositries.GetSecurityRepository();

            try
            {
                var security = securityRepository.All().ToList().First();
                var plainText = password + security.PasswordSalt;
                var hash = PasswordService.CalculateHash(plainText);
                return hash == security.Password;
            }
            catch (Exception ex)
            {
                throw new MembershipServiceException(ex);
            }
        }
    }
}
