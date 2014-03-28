using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Presentation.Views;

namespace UITest
{
    public partial class AddEditEditQuestionForm : Form, IAddEditQuestionView
    {
        private const string BeginTextboxForVariant = "tbxVariant";
        private const string BeginCheckBoxForVariant = "chbxVariant";
        private ApplicationContext _context;
        private readonly int[] _counters = { 2, 3, 4, 5 };
        private const int CountOfVariants = 5;
        private int _countForReadOnly;

        public AddEditEditQuestionForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            cmbxCounters.DataSource = _counters;
            cmbxCounters.SelectedIndex = 0;
            btnEdit.Visible = false;
            btnSaveQuestion.Visible = false;

            FormClosed += (sender, args) => Invoke(ContextDispose);
            btnAddQuestion.Click += (sender, args) => Invoke(AddQuestion);
        }

        public event Action ContextDispose;
        public event Action AddQuestion;

        public Dictionary<string, bool> GetVariants
        {
            get
            {
                var list = new Dictionary<string, bool>();
                for (var i = 1; i <= (int)cmbxCounters.SelectedItem; i++)
                {
                    var text = Controls[BeginTextboxForVariant + i].Text;
                    var isRight = ((CheckBox)Controls[BeginCheckBoxForVariant + i]).Checked;
                    if (text == "")
                    {
                        return null;
                    }
                    try
                    {
                        list.Add(text, isRight);
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
                return list;
            }
        }

        public string GetDescription
        {
            get
            {
                var description = tbxDescrition.Text;
                return description;
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearValues()
        {
            for (var i = 1; i <= CountOfVariants; i++)
            {
                Controls[BeginTextboxForVariant + i].Text = String.Empty;
                ((CheckBox)Controls[BeginCheckBoxForVariant + i]).Checked = false;
            }
            tbxDescrition.Text = String.Empty;
        }

        public void SetValues(Question question)
        {
            //Performance???!!!
            cmbxCounters.SelectedIndex = question.Variants.Count - 2;
            btnAddQuestion.Visible = false;
            tbxDescrition.Text = question.Description;
            for (var i = 0; i < question.Variants.Count; i++)
            {
                Controls[BeginTextboxForVariant + (i + 1)].Text = question.Variants.ElementAt(i).Description;
                ((CheckBox)Controls[BeginCheckBoxForVariant + (i + 1)]).Checked =
                    question.Variants.ElementAt(i).IsRight;
            }
            _countForReadOnly = question.Variants.Count;

            ControlsReadOnly(question.Variants.Count, true);
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        private void cmbxCounters_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAll();
            var result = (int)cmbxCounters.SelectedItem;
            for (var i = 1; i <= result; i++)
            {
                Controls[BeginTextboxForVariant + i].Visible = true;
                Controls[BeginCheckBoxForVariant + i].Visible = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ControlsReadOnly(_countForReadOnly, false);
        }

        #region [Helper methods]

        private void HideAll()
        {
            for (var i = 1; i <= CountOfVariants; i++)
            {
                Controls[BeginTextboxForVariant + i].Visible = false;
                Controls[BeginCheckBoxForVariant + i].Visible = false;
            }
        }

        private void ControlsReadOnly(int count, bool isReadOnly)
        {
            btnSaveQuestion.Visible = !isReadOnly;
            btnEdit.Visible = isReadOnly;
            tbxDescrition.ReadOnly = isReadOnly;
            cmbxCounters.Enabled = !isReadOnly;
            for (var i = 1; i <= count; i++)
            {
                ((TextBox)Controls[BeginTextboxForVariant + i]).ReadOnly = isReadOnly;
                Controls[BeginCheckBoxForVariant + i].Enabled = !isReadOnly;
            }
        }

        #endregion
    }
}
