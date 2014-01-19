using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AR.EPAM.Infrastructure.Guard;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Services.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class VariantService : IService
    {
        #region [Private members]

        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        #endregion


        #region [Ctor's]

        public VariantService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        #endregion


        #region [VariantService's members]

        public List<Variant> GetVariantsByQuestionId(Guid questionId)
        {
            var variantRepository = _factoryOfRepositries.GetVariantRepository();
            try
            {
                var variants = variantRepository.All().Where(e => e.QuestionId == questionId).ToList();

                Guard.AgainstNullReference<VariantServiceException>(variants, "variants",
                    "There is no variants for this question");

                return variants.ToList();
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message);
            }
        }

        #endregion

    }
}
