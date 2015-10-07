using System;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface ILoginStudentView : IMessagableView
    {
        Student GetStudentData();

        event Action StartTest;
        event Action ContextDispose;
    }
}