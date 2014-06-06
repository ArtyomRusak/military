using System;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface ILoginView : IView
    {
        string Password { get; }
        event Action LoginAsStudent;
        event Action LoginAsTeacher;
        event Action ContextDisposed;
        void ShowError(string message);
    }
}
