namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class TestConfig : Entity<int>
    {
        public TestConfig()
        {
            this.NumberOfQuestions = 15;
        }

        public int NumberOfQuestions { get; set; }
        public virtual Test Test { get; set; }
    }
}