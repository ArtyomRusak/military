using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class ServiceException : Exception
    {
        protected ServiceException()
        {

        }

        public ServiceException(string message)
            : base(message)
        {

        }

        public ServiceException(Exception ex)
            : base("See inner exception", ex)
        {

        }
    }
}
