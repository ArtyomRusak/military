using System;
using System.Collections.Generic;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Question : Entity<Guid>
    {
        public Question()
        {
            Variants = new HashSet<Variant>();
        }

        public string Description { get; set; }
        public virtual ICollection<Variant> Variants { get; set; } 
    }
}
