using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class VariantServiceException : ServiceException
    {
        protected VariantServiceException()
        {

        }

        public VariantServiceException(string message)
            : base(message)
        {

        }

        public VariantServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}
