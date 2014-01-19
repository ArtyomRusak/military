using System;

namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Variant : Entity<Guid>
    {
        public Question Question { get; set; }
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
        public bool IsRight { get; set; }
    }
}
