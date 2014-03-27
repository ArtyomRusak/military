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
    public partial class AddQuestionForm : Form, IAddQuestionView
    {
        const string BeginLabelForVariant = "lblVariant";
        const string BeginTextboxForVariant = "tbxVariant";
        const string BeginCheckBoxForVariant = "chbxVariant";
        private ApplicationContext _context;
        private readonly int[] _counters = { 1, 2, 3, 4, 5 };

        public AddQuestionForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            cmbxCounters.DataSource = _counters;
            cmbxCounters.SelectedIndex = 0;

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
                    list.Add(text, isRight);
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

        public void ShowError(string message)
        {
            MessageBox.Show(message);
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
                Controls[BeginLabelForVariant + i].Visible = true;
                Controls[BeginTextboxForVariant + i].Visible = true;
                Controls[BeginCheckBoxForVariant + i].Visible = true;
            }
        }

        private void HideAll()
        {
            for (var i = 1; i <= 5; i++)
            {
                Controls[BeginLabelForVariant + i].Visible = false;
                Controls[BeginTextboxForVariant + i].Visible = false;
                Controls[BeginCheckBoxForVariant + i].Visible = false;
            }
        }
    }
}
