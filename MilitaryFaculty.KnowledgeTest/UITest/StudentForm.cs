using System;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace UITest
{
    public partial class StudentForm : Form, IStudentView
    {
        public StudentForm()
        {
            InitializeComponent();

            btnStartTest.Click += (sender, args) => Invoke(this.StartTest);
            this.Closed += (sender, args) => Invoke(this.ContextDispose);
        }

        public event Action StartTest;
        public event Action ContextDispose;

        public void ShowMessage(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        public Student GetStudentData()
        {
            int platoon;
            int.TryParse(tbxGroupNumber.Text, out platoon);
            var student = new Student
            {
                Name = tbxName.Text,
                Surname = tbxSurname.Text,
                Platoon = platoon
            };

            return student;
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