using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class TestServiceException : ServiceException
    {
        protected TestServiceException()
        {

        }

        public TestServiceException(string message)
            : base(message)
        {

        }

        public TestServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}
