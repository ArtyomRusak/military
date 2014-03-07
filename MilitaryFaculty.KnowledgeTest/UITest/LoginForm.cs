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
    public partial class LoginForm : Form, ILoginView
    {
        private readonly ApplicationContext _context;

        public LoginForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            FormClosed += (sender, args) => Invoke(ContextDisposed);
            btnStudent.Click += (sender, args) => Invoke(LoginAsStudent);
            btnTeacher.Click += (sender, args) => Invoke(LoginAsTeacher);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public string Password { get { return tbxPassword.Text; } }

        public event Action LoginAsStudent;
        public event Action LoginAsTeacher;
        public event Action ContextDisposed;

        public void ShowError(string message)
        {
            MessageBox.Show(message);
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
