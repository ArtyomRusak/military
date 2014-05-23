using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IMainTeacherView : IView
    {
        event Action AddQuestion;
        event Action TestButton;
        event Action ContextDispose;
        event Action LoadQuestions;

        void SetNonBindedQuestions(List<Question> nonBindedQuestions,
            List<Question> bindedQuestions);
    }
}
