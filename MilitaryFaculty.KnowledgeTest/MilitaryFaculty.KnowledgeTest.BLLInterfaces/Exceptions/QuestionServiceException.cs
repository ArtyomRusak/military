using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class QuestionServiceException : ServiceException
    {
        protected QuestionServiceException()
        {

        }

        public QuestionServiceException(string message)
            : base(message)
        {

        }

        public QuestionServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}
