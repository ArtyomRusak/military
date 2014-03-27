using System;

namespace MilitaryFaculty.KnowledgeTest.BLLInterfaces.Exceptions
{
    public class MembershipServiceException : ServiceException
    {
        protected MembershipServiceException()
        {

        }

        public MembershipServiceException(string message)
            : base(message)
        {

        }

        public MembershipServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}
