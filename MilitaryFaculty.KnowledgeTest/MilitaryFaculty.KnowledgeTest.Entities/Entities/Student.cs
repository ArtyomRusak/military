using System;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Student : Entity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Platoon { get; set; }
        public int Result { get; set; }

        public void SetResult(int result)
        {
            Result = result;
        }
    }
}
