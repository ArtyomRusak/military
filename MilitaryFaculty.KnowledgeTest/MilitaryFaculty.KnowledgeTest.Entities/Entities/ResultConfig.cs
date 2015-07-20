namespace MilitaryFaculty.KnowledgeTest.Entities.Entities
{
    public class ResultConfig : Entity<int>
    {
        public int PercentOfRightAnswers { get; set; }
        public bool FullAnswer { get; set; }
    }
}