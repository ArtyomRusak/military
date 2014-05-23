using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Test : Entity<int>
    {
        public string Name { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
