using System;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Presentation.Models;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace UITest
{
    public partial class TestForm : Form, ITestView
    {
        private readonly ApplicationContext _context;
        private const string BeginTextboxForVariant = "tbxVariant";
        private const string BeginCheckBoxForVariant = "chbxVariant";

        public TestForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            this.Load += (sender, args) => Invoke(LoadForm);
            this.Closed += (sender, args) => Invoke(ContextDispose);
            btnNextQuestion.Click += (sender, args) => Invoke(NextQuestionChoosed);
        }

        public event Action NextQuestionChoosed;
        public event Action LoadForm;
        public event Action ContextDispose;

        public void SetVariantCheckbox(int shift, int variantId)
        {
            Controls["questionPanel"].Controls[BeginCheckBoxForVariant + shift].Tag = new {VariantId = variantId};
        }

        public void SetVariantTextbox(int shift, string text)
        {
            Controls["questionPanel"].Controls[BeginTextboxForVariant + shift].Text = text;
        }

        public void SetQuestionText(string questionText)
        {
            tbxQuestionText.Text = questionText;
        }

        public void SetQuestionCounter(int counter)
        {
            lblQuestionCounter.Text = String.Format("Вопрос №{0}", counter);
        }

        public void SetVariantCheckboxVisibility(int shift, bool visible)
        {
            Controls["questionPanel"].Controls[BeginCheckBoxForVariant + shift].Visible = visible;
        }

        public void SetVariantTextboxVisibility(int shift, bool visible)
        {
            Controls["questionPanel"].Controls[BeginTextboxForVariant + shift].Visible = visible;
        }

        public IResultItem GetQuestionAnswer()
        {
            throw new System.NotImplementedException();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}