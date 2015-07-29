using System;
using System.Collections.Generic;
using MilitaryFaculty.KnowledgeTest.Presentation.Models;

namespace MilitaryFaculty.KnowledgeTest.Presentation.Views
{
    public interface ITestView : IMessagableView
    {
        event Action NextQuestionChoosed;
        event Action FinishingTest;
        event Action LoadForm;
        event Action ContextDispose;
        void SetVariantCheckbox(int shift, int variantId);
        void SetVariantTextbox(int shift, string text);
        void SetQuestionText(string questionText);
        void SetQuestionCounter(int counter);
        void SetVariantCheckboxVisibility(int shift, bool visible);
        void SetVariantTextboxVisibility(int shift, bool visible);
        IList<IAnswerItem> GetQuestionAnswers();
        void ShowFinishButton();
    }
}