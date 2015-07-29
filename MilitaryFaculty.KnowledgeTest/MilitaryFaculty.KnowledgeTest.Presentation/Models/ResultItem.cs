namespace MilitaryFaculty.KnowledgeTest.Presentation.Models
{
    public class ResultItem : IResultItem
    {
        private int _koefficient;
        public int CountOfRightAnswers { get; set; }
        public int CountOfWrongAnswers { get; set; }
        public bool IsRight { get; set; }

        public int Koefficient
        {
            get { return _koefficient; }
            set { _koefficient = value < 0 ? 0 : value; }
        }
    }
}
