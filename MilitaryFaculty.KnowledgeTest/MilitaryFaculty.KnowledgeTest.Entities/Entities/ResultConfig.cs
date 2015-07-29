using System.Collections.Generic;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class ResultConfig : Entity<int>
    {
        public ResultConfig()
        {
            this.Tests = new List<Test>();
        }

        public short PercentOfRightAnswers { get; set; }
        public bool FullAnswer { get; set; }
        public bool IgnoreWrongAnswers { get; set; }
        public string Description { get; set; }
        public virtual IList<Test> Tests { get; set; }
    }
}