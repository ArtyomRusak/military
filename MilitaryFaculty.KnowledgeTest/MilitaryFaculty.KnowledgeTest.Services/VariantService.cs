using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class VariantService : IService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public VariantService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public List<Variant> GetVariantsByQuestionId(int questionId)
        {
            var variantRepository = _factoryOfRepositries.GetVariantRepository();
            try
            {
                return variantRepository.Filter(e => e.QuestionId == questionId).ToList();
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message);
            }
        }
    }
}
