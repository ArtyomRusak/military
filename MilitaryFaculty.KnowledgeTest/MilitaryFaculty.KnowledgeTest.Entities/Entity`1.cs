using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Entities
{
    public class Entity<TKey> : Entity
    {
        public TKey Id { get; set; }
    }
}
