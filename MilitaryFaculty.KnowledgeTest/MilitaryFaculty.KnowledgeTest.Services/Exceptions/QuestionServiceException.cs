using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Services.Exceptions
{
    public class QuestionServiceException : ServiceException
    {
        protected QuestionServiceException()
        {

        }

        public QuestionServiceException(string message)
            : base(message)
        {

        }

        public QuestionServiceException(Exception ex)
            : base(ex)
        {

        }
    }
}
