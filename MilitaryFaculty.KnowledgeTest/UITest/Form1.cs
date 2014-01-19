using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Initializers;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.Repositories;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Entities.Exceptions;
using MilitaryFaculty.KnowledgeTest.Services;
using MilitaryFaculty.KnowledgeTest.Services.Exceptions;
using MilitaryFaculty.KnowledgeTest.Entities;

namespace UITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Database.SetInitializer(new RecreateAlways());
            TestContext context = new TestContext("test");
            UnitOfWork unitOfWork = new UnitOfWork(context);
            MembershipService service = new MembershipService(unitOfWork, unitOfWork);
            try
            {
                var student = service.AddStudent("Artyom", "Rusak", 11115);
                context.Students.Add(new Student() {Id = Guid.NewGuid(), Name = "q", Surname = "w", Platoon = 111});
                //unitOfWork.Dispose();
                unitOfWork.Commit();
                unitOfWork.Commit();
                unitOfWork.Dispose();
            }
            catch (RepositoryException ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            catch (MembershipServiceException exception)
            {
                MessageBox.Show(exception.ErrorMessage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Database.SetInitializer(new RecreateIfModelChanges());
            TestContext context = new TestContext("test");
            var transaction = context.Database.BeginTransaction();
            var security = new Security() { Password = 1, PasswordSalt = DateTime.Now.ToString() };
            context.Security.Add(security);
            //context.SaveChanges();

            this.textBox1.Text = security.Id.ToString();

            transaction.Commit();
            //transaction.Rollback();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestContext context = new TestContext("test");
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            IRepositoryFactory factory = (IRepositoryFactory) unitOfWork;
            VariantService service = new VariantService(unitOfWork, factory);
            var questionRepository = new Repository<Question, Guid>(context);
            var variants = service.GetVariantsByQuestionId(
                questionRepository.Filter(ee => ee.Description.Contains("text")).FirstOrDefault().Id);
            foreach (var variant in variants)
            {
                variant.Description = "Another description";
            }

            unitOfWork.Commit();
        }
    }
}
