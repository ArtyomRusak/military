using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class StudentServiceException : ServiceException
    {
        protected StudentServiceException()
        {

        }

        public StudentServiceException(string message)
            : base(message)
        {

        }

        public StudentServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}