namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class Variant : Entity<int>
    {
        public string Description { get; set; }
        public bool IsRight { get; set; }
        public virtual Question Question { get; set; }
        public int QuestionId { get; set; }
    }
}
