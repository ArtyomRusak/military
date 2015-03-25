using System;
using System.Collections.Generic;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IAddEditQuestionView : IView
    {
        event Action ContextDispose;
        event Action AddQuestion;
        event Action UpdateQuestion;
        Dictionary<string, object> GetVariants(bool isTag);
        string GetDescription { get; }
        int GetQuestionId { get; }
        void ShowMessage(string message);
        void ClearValues();
        void SetValues(Question question);
    }
}
