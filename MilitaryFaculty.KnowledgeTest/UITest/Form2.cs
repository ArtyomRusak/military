using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;

namespace UITest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestContext context = new TestContext("test");
            var security = context.Security.SingleOrDefault(ee => ee.Id == 1);
            if ((this.textBox2.Text + security.PasswordSalt).GetHashCode() == security.Password)
            {
                this.textBox1.Text = "True";
            }
            else
            {
                this.textBox1.Text = "False";
            }
            context.Dispose();
        }
    }
}
