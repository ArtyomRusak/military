using System.Collections.Generic;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Test : Entity<int>
    {
        public string Name { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
