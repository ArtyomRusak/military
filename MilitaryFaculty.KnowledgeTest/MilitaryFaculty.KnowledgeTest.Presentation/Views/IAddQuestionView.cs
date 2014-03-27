using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IAddQuestionView : IView
    {
        event Action ContextDispose;
        event Action AddQuestion;
        Dictionary<string, bool> GetVariants { get; }
        string GetDescription { get; }
        void ShowError(string message);
    }
}
