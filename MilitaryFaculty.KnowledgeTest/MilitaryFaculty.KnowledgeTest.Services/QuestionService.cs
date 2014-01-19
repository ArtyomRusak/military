using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class QuestionService : IService
    {
        #region [Private members]

        private IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        #endregion


        #region [Ctor's]

        public QuestionService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        #endregion

        #region [QuestionService's members]

        public List<Question> GetAllQuestions()
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();
            try
            {
                var questions = questionRepository.All().ToList();
                return questions.ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message);
            }
        }

        #endregion
    }
}
