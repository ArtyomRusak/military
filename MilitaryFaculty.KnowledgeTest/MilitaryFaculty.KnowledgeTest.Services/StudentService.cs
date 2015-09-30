using System;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public StudentService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public Student AddStudent(Student student)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();

            StudentService.UpperNameAndSurnameForStudent(student);
            studentRepository.Add(student);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new StudentServiceException(ex);
            }

            return student;
        }

        public Student AddStudent(string name, string surname, int platoon)
        {
            var student = new Student { Name = name.ToUpperInvariant(), Surname = surname.ToUpperInvariant(), Platoon = platoon };
            student = AddStudent(student);
            return student;
        }

        public Student GetStudentById(int studentId)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();

            try
            {
                var student = studentRepository.GetEntityById(studentId);
                return student;
            }
            catch (Exception ex)
            {
                throw new StudentServiceException(ex);
            }
        }

        public Student GetStudent(Student student)
        {
            return this.GetStudent(student.Name, student.Surname, student.Platoon);
        }

        public Student GetStudent(string name, string surname, int platoon)
        {
            var studentRepository = _factoryOfRepositries.GetStudentRepository();

            try
            {
                var student =
                    studentRepository.All()
                        .ToList()
                        .FirstOrDefault(
                            mod => String.Equals(mod.Name, name.ToUpperInvariant()) && String.Equals(mod.Surname, surname.ToUpperInvariant()) && mod.Platoon == platoon);
                return student;
            }
            catch (Exception ex)
            {
                throw new StudentServiceException(ex);
            }
        }

        private static void UpperNameAndSurnameForStudent(Student student)
        {
            student.Name = student.Name.ToUpperInvariant();
            student.Surname = student.Surname.ToUpperInvariant();
        }
    }
}