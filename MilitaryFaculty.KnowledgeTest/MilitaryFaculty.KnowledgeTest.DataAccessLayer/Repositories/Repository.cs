using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.Entities.InterfacesOfRepositories;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.Repositories
{
    public class Repository : IRepository
    {
        protected TestContext Context;

        public Repository(TestContext context)
        {
            Context = context;
        }
    }
}
