namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class TestConfig : Entity<int>
    {
        public int NumberOfQuestions { get; set; }
        public virtual Test Test { get; set; }
    }
}