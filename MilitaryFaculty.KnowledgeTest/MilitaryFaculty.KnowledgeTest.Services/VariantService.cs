using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;
using MilitaryFaculty.KnowledgeTest.Services.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class VariantService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public VariantService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public void AddVariantToQuestion(string description, bool isRight, int questionId)
        {
            var variantRepository = _factoryOfRepositries.GetVariantRepository();

            var variant = new Variant { Description = description, IsRight = isRight, QuestionId = questionId };
            variantRepository.Add(variant);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception e)
            {
                throw new VariantServiceException(e);
            }
        }

        public void UpdateVariant(Variant variant)
        {
            var variantRepository = _factoryOfRepositries.GetVariantRepository();
            variantRepository.Update(variant);
        }

        public void RemoveVariant(int variantId)
        {
            var variantRepository = _factoryOfRepositries.GetVariantRepository();
            var variant = variantRepository.GetEntityById(variantId);
            variantRepository.Remove(variant);
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
