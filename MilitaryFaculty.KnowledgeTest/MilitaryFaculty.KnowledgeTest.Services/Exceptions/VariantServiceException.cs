using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Services.Exceptions
{
    public class VariantServiceException : ServiceException
    {
        public string ErrorMessage { get; set; }

        public VariantServiceException()
        {

        }

        public VariantServiceException(string message)
        {
            ErrorMessage = message;
        }
    }
}
