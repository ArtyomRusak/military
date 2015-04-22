namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IMessagableView : IView
    {
        void ShowMessage(string message, string caption);
    }
}