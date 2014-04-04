using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces;
using MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions;
using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Infrastructure.Guard.Validation;

namespace MilitaryFaculty.KnowledgeTest.Services
{
    public class QuestionService : IQuestionService
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

        public void UpdateQuestion(int questionId, string description)
        {
            var question = GetQuestionById(questionId);
            question.Description = description;
            UpdateQuestion(question);
        }

        public void RemoveQuestion(Question question)
        {
            var questionRepository = _factoryOfRepositries.GetQuestionRepository();
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
