using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            btnTest.Click += (sender, args) => Invoke(TestButton);
            FormClosed += (sender, args) => Invoke(ContextDispose);
            Load += (sender, args) => Invoke(LoadQuestions);
        }

        public event Action AddQuestion;
        public event Action TestButton;
        public event Action ContextDispose;
        public event Action LoadQuestions;

        public void SetNonBindedQuestions(List<Question> nonBindedQuestions,
            List<Question> bindedQuestions)
        {
            dgvNonBindedQuestions.DataSource = nonBindedQuestions;
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

        private void dgvNonBindedQuestions_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var data = dgvNonBindedQuestions.Rows[e.RowIndex].Cells;
            MessageBox.Show(String.Format("Id - {0}, Description - {1}", data[0].Value, data[1].Value));
        }
    }
}
