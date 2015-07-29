using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class ResultServiceException : ServiceException
    {
        protected ResultServiceException()
        {

        }

        public ResultServiceException(string message)
            : base(message)
        {

        }

        public ResultServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}