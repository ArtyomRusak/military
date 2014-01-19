﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AR.EPAM.Infrastructure.Guard.Exceptions;

namespace MilitaryFaculty.KnowledgeTest.Services.Exceptions
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
