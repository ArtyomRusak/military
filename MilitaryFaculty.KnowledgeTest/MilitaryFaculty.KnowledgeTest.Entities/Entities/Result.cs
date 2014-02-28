using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Result : Entity<int>
    {
        public double Mark { get; set; }
        public DateTime Date { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
