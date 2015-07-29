using System;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Result : Entity<int>
    {
        public int CountOfRightAnswers { get; set; }
        public int CountOfWrongAnswers { get; set; }
        public bool Success { get; set; }
        public double Mark { get; set; }
        public DateTime Date { get; set; }
        public ResultConfig ResultConfig { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}