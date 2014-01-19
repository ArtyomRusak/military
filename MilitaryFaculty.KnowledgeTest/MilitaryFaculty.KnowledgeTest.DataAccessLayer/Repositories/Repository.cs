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
