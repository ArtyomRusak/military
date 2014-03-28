using System.Collections.Generic;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Question : Entity<int>
    {
        public string Description { get; set; }
        public virtual HashSet<Variant> Variants { get; set; }
    }
}
