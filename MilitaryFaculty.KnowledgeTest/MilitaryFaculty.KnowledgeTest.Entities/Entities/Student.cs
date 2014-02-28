using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Student : Entity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Platoon { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
