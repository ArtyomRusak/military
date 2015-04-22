using System;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface ILoginView : IMessagableView
    {
        string Password { get; }
        event Action LoginAsStudent;
        event Action LoginAsTeacher;
        event Action ContextDisposed;
    }
}