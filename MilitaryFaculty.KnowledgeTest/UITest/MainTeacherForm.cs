using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;
using UITest.Properties;

namespace UITest
{
    public partial class MainTeacherForm : Form, IMainTeacherView
    {
        private readonly ApplicationContext _context;

        public MainTeacherForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            btnAddQuestion.Click += (sender, args) =>
            {
                Invoke(AddQuestion);
                Invoke(LoadQuestions);
            };
            _btnSaveChanges.Click += (sender, args) => this.Invoke(SaveChangesToTest);
            this.FormClosed += (sender, args) => this.Invoke(CloseFromDisposeContextAndOpenLoginForm);
            this.Load += (sender, args) => this.Invoke(LoadQuestions);
            _dgvNonBindedQuestions.CellDoubleClick += this.GetQuestion;
            _addQuestionToTestBtn.Click += (sender, args) => this.Invoke(AddQuestionToTest);
            _removeQuestionFromTestBtn.Click += (sender, args) => this.Invoke(RemoveQuestionFromTest);
        }

        public event Action AddQuestion;
        public event Action SaveChangesToTest;
        public event Action ContextDispose;
        public event Action LoadQuestions;
        public event Action AddQuestionToTest;
        public event Action RemoveQuestionFromTest;
        public event Action CloseFromDisposeContextAndOpenLoginForm;
        public event Action<Question> OpenEditQuestionForm;

        public void SetNonBindedQuestions(IList<Question> nonBindedQuestions)
        {
            _dgvNonBindedQuestions.DataSource = nonBindedQuestions;
        }

        public void SetDatasourcesToNull()
        {
            _dgvNonBindedQuestions.DataSource = null;
            _dgvBindedQuestions.DataSource = null;
        }

        public void SetBindedQuestions(IList<Question> questions)
        {
            _dgvBindedQuestions.DataSource = questions;
        }

        public void GetQuestion(object sender, DataGridViewCellEventArgs args)
        {
            var item = (Question)_dgvNonBindedQuestions.Rows[args.RowIndex].DataBoundItem;
            OpenEditQuestionForm(item);
        }

        public Question GetSelectedRowFromNonBindedQuestions()
        {
            var question = (Question)_dgvNonBindedQuestions.SelectedRows[0].DataBoundItem;
            return question;
        }

        public Question GetSelectedRowFromBindedQuestions()
        {
            var question = (Question)_dgvBindedQuestions.SelectedRows[0].DataBoundItem;
            return question;
        }

        public bool ViewQuestionToConfirm()
        {
            var confirm = MessageBox.Show(Resources.SaveChangesToTestString, string.Empty,
                MessageBoxButtons.YesNo);
            return confirm.ToString() == "Yes";
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
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
