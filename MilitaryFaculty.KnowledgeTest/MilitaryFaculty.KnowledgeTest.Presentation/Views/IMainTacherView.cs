using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IMainTeacherView : IView
    {
        event Action AddQuestion;
        event Action TestButton;
        event Action ContextDispose;
    }
}
