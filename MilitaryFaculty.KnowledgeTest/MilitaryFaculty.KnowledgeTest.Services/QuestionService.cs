using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;
using MilitaryFaculty.KnowledgeTest.Services.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class QuestionService : IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _factoryOfRepositries;

        public QuestionService(IUnitOfWork unitOfWork, IRepositoryFactory factoryOfRepositories)
        {
            Guard.AgainstNullReference(unitOfWork, "unitOfWork");
            Guard.AgainstNullReference(factoryOfRepositories, "factoryOfRepositories");

            _unitOfWork = unitOfWork;
            _factoryOfRepositries = factoryOfRepositories;
        }

        public Question AddQuestion(string description)
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();

            var question = new Question {Description = description};
            questionRepository.Add(question);

            try
            {
                _unitOfWork.PreSave();
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex);
            }

            return question;
        }

        public Question GetQuestionById(int questionId)
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();

            try
            {
                return questionRepository.GetEntityById(questionId);
            }
            catch (Exception e)
            {
                throw new QuestionServiceException(e);
            }
        }

        public void UpdateQuestion(Question question)
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();

            try
            {
                questionRepository.Update(question);
            }
            catch (Exception e)
            {
                throw new QuestionServiceException(e);
            }
        }

        public void RemoveQuestion(int questionId)
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();
            var question = questionRepository.GetEntityById(questionId);
            questionRepository.Remove(question);
        }

        public List<Question> GetAllQuestions()
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();
            try
            {
                return questionRepository.All().ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message);
            }
        }
    }
}
