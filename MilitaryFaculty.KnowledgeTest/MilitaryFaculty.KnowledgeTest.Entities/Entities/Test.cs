using System.Collections.Generic;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Test : Entity<int>
    {
        public Test()
        {
            this.Questions = new List<Question>();
        }

        public string Name { get; set; }
        public virtual List<Question> Questions { get; set; }
        public virtual TestConfig TestConfig { get; set; }
        public virtual ResultConfig ResultConfig { get; set; }
    }
}