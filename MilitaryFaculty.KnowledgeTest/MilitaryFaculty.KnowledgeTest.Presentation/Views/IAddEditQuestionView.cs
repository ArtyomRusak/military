using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IAddEditQuestionView : IView
    {
        event Action ContextDispose;
        event Action AddQuestion;
        Dictionary<string, bool> GetVariants { get; }
        string GetDescription { get; }
        void ShowMessage(string message);
        void ClearValues();
        void SetValues(Question question);
    }
}
