using System;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface ILoginView : IMessagableView
    {
        string Password { get; }
        bool IsStartPoint { get; set; }
        event Action LoginAsStudent;
        event Action LoginAsTeacher;
        event Action ContextDisposed;
    }
}