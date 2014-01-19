using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Entities
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();

        void PreSave();
    }
}
