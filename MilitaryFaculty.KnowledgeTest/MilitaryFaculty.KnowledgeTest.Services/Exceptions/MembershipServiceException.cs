﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AR.EPAM.Infrastructure.Guard.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services.Exceptions
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
