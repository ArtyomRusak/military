using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IMainTeacherView : IView
    {
        event Action AddQuestion;
        event Action TestButton;
        event Action ContextDispose;
        event Action LoadQuestions;
        event Action<Question> OpenEditQuestionForm;

        void SetNonBindedQuestions(IList<Question> nonBindedQuestions);

        void SetDatasourcesToNull();

        void SetBindedQuestions(IList<Question> questions);

        void GetQuestion(object sender, DataGridViewCellEventArgs args);
    }
}
