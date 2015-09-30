using System;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace UITest
{
    public partial class LoginStudentForm : Form, ILoginStudentView
    {
        public LoginStudentForm()
        {
            InitializeComponent();

            this.Closed += (sender, args) => this.Invoke(CloseFormAndDisposeContext);
            this.btnAccess.Click += (sender, args) => this.Invoke(AccessTest);
        }

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        public Student GetStudentFormData()
        {
            var result = new Student
            {
                Name = this.tbxName.Text,
                Surname = this.tbxSurname.Text,
                Platoon = (int)this.numGroup.Value
            };
            return result;
        }

        public event Action AccessTest;
        public event Action CloseFormAndDisposeContext;

        public void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}