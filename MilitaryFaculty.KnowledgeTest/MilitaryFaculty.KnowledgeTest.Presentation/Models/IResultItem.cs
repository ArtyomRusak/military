namespace MilitaryFaculty.KnowledgeTest.Presentation.Models
{
    public interface IResultItem
    {
        int CountOfRightAnswers { get; set; }
        int CountOfWrongAnswers { get; set; }
        bool IsRight { get; set; }
        int Koefficient { get; set; }
    }
}
