using System;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public TestService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public Test GetTestSingleton()
        {
            var testRepository = _factoryOfRepositries.GetTestRepository();

            try
            {
                var test = testRepository.All().FirstOrDefault();
                return test;
            }
            catch (Exception ex)
            {
                throw new TestServiceException(ex);
            }
        }
    }
}