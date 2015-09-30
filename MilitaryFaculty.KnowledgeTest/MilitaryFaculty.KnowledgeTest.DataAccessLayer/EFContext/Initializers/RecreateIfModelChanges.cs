using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Transactions;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;
using MilitaryFaculty.KnowledgeTest.Infrastructure;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Initializers
{
    public class RecreateIfModelChanges : IDatabaseInitializer<TestContext>
    {
        public void InitializeDatabase(TestContext context)
        {
            bool databaseExists;
            using (new TransactionScope(TransactionScopeOption.Suppress))
            {
                databaseExists = context.Database.Exists();
            }
            if (databaseExists)
            {
                if (context.Database.CompatibleWithModel(true))
                {
                    return;
                }
                context.Database.Delete();
            }
            context.Database.Create();
            try
            {
                context.SaveChanges();
                Seed(context);
            }
            catch (Exception ex)
            {
                context.Dispose();
                throw;
            }
        }

        protected void Seed(TestContext context)
        {
            var mainTest = new Test { Name = "MainTest" };
            var mainTestConfiguration = new TestConfig { NumberOfQuestions = 15, Test = mainTest };
            var resultTestConfiguration = new ResultConfig
            {
                FullAnswer = true,
                PercentOfRightAnswers = 70,
                Description = "Базовый",
            };
            mainTest.ResultConfig = resultTestConfiguration;
            context.Tests.Add(mainTest);
            context.TestConfigs.Add(mainTestConfiguration);
            context.ResultConfigs.Add(resultTestConfiguration);
            context.SaveChanges();

            var questions = new List<Question>()
            {
                new Question {Description = "Edit text1."}, 
                new Question {Description = "Edit text2."},
                new Question {Description = "Edit text3."},
                new Question {Description = "Edit text4."},
                new Question {Description = "Edit text5."},
                new Question {Description = "Edit text6."},
                new Question {Description = "Edit text7."},
                new Question {Description = "Edit text8."},
                new Question {Description = "Edit text9."},
                new Question {Description = "Edit text10."},
                new Question {Description = "Edit text11."},
                new Question {Description = "Edit text12."},
                new Question {Description = "Edit text13."},
                new Question {Description = "Edit text14."},
                new Question {Description = "Edit text15."},
            };
            //questions.ForEach(e => context.Questions.Add(e));
            questions.ForEach(delegate(Question question)
            {
                question.Tests.Add(mainTest);
                context.Questions.Add(question);
            });

            context.SaveChanges();

            foreach (var question in questions)
            {
                new List<Variant>()
                {
                    new Variant {QuestionId = question.Id, IsRight = false, Description = "Set text1"},
                    new Variant {QuestionId = question.Id, IsRight = false, Description = "Set text2"},
                    new Variant {QuestionId = question.Id, IsRight = false, Description = "Set text3"},
                    new Variant {QuestionId = question.Id, IsRight = false, Description = "Set text4"},
                    new Variant {QuestionId = question.Id, IsRight = false, Description = "Set text5"},
                }.ForEach(e => context.Variants.Add(e));
            }

            context.SaveChanges();

            var passwordSalt = DateTime.Now.ToString();
            var plainText = "638638" + passwordSalt;
            var password = PasswordService.CalculateHash(plainText);
            var security = new Security { Password = password, PasswordSalt = passwordSalt };
            context.Security.Add(security);

            context.SaveChanges();
        }
    }
}
