using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface IMainTeacherView : IMessagableView
    {
        event Action AddQuestion;
        event Action SaveChangesToTest;
        event Action ContextDispose;
        event Action LoadQuestions;
        event Action AddQuestionToTest;
        event Action RemoveQuestionFromTest;
        event Action<Question> OpenEditQuestionForm;

        void SetNonBindedQuestions(IList<Question> nonBindedQuestions);

        void SetDatasourcesToNull();

        void SetBindedQuestions(IList<Question> questions);

        void GetQuestion(object sender, DataGridViewCellEventArgs args);

        Question GetSelectedRowFromNonBindedQuestions();

        Question GetSelectedRowFromBindedQuestions();
    }
}