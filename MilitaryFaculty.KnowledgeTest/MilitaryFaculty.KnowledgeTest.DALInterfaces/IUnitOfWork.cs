using System;

namespace MilitaryFaculty.KnowledgeTest.DALInterfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();

        void PreSave();
    }
}
