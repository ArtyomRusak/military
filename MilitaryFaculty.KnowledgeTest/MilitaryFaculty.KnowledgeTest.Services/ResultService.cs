using System;
using System.Collections.Generic;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class ResultService : IResultService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public ResultService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public Result AddResult(Result result)
        {
            var resultService = _factoryOfRepositries.GetResultRepository();

            result.Date = DateTime.Now;
            resultService.Add(result);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new ResultServiceException(ex);
            }

            return result;
        }

        public Result AddResult(int countOfRightAnswers, int countOfWrongAnswers, bool success, double mark,
            int studentId,
            ResultConfig resultConfig)
        {
            var result = new Result
            {
                CountOfRightAnswers = countOfRightAnswers,
                CountOfWrongAnswers = countOfWrongAnswers,
                Success = success,
                Mark = mark,
                StudentId = studentId,
                ResultConfig = resultConfig
            };
            result = AddResult(result);
            return result;
        }

        public IList<Result> GetResults()
        {
            throw new NotImplementedException();
        }

        public IList<Result> GetResultsByStudentId(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}