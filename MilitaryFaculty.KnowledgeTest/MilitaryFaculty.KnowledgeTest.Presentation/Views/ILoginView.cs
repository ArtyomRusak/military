using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
