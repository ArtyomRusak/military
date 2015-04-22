using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

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
            _btnSaveChanges.Click += (sender, args) => Invoke(SaveChangesToTest);
            FormClosed += (sender, args) => Invoke(ContextDispose);
            Load += (sender, args) => Invoke(LoadQuestions);
            _dgvNonBindedQuestions.CellDoubleClick += GetQuestion;
            _addQuestionToTestBtn.Click += (sender, args) => Invoke(AddQuestionToTest);
            _removeQuestionFromTestBtn.Click += (sender, args) => Invoke(RemoveQuestionFromTest);
        }

        public event Action AddQuestion;
        public event Action SaveChangesToTest;
        public event Action ContextDispose;
        public event Action LoadQuestions;
        public event Action AddQuestionToTest;
        public event Action RemoveQuestionFromTest;
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

        private void dgvNonBindedQuestions_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex < 0)
            //{
            //    return;
            //}
            //var data = dgvNonBindedQuestions.Rows[e.RowIndex].Cells;
            //MessageBox.Show(String.Format("Id - {0}, Description - {1}", data[0].Value, data[1].Value));
        }
    }
}
