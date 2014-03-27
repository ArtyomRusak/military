using MilitaryFaculty.KnowledgeTest.DALInterfaces;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;

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
