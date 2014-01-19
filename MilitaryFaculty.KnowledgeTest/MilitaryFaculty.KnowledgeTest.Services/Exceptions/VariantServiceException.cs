using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Services.Exceptions
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
