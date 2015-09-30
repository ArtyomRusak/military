using System;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface ILoginStudentView : IMessagableView
    {
        Student GetStudentFormData();

        event Action AccessTest;
        event Action CloseFormAndDisposeContext;
    }
}