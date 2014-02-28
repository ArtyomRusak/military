using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Transactions;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

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
            var questions = new List<Question>()
            {
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
                new Question() {Description = "Edit text."},
            };
            questions.ForEach(e => context.Questions.Add(e));

            context.SaveChanges();

            foreach (var question in questions)
            {
                new List<Variant>()
                {
                    new Variant() {QuestionId = question.Id, IsRight = false, Description = "Set text"},
                    new Variant() {QuestionId = question.Id, IsRight = false, Description = "Set text"},
                    new Variant() {QuestionId = question.Id, IsRight = false, Description = "Set text"},
                    new Variant() {QuestionId = question.Id, IsRight = false, Description = "Set text"},
                    new Variant() {QuestionId = question.Id, IsRight = false, Description = "Set text"},
                }.ForEach(e => context.Variants.Add(e));
            }

            context.SaveChanges();
        }
    }
}
