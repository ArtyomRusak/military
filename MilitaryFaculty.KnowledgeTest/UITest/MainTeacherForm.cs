using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            btnAddQuestion.Click += (sender, args) => Invoke(AddQuestion);
            btnTest.Click += (sender, args) => Invoke(TestButton);
            FormClosed += (sender, args) => Invoke(ContextDispose);
        }

        public event Action AddQuestion;
        public event Action TestButton;
        public event Action ContextDispose;

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
