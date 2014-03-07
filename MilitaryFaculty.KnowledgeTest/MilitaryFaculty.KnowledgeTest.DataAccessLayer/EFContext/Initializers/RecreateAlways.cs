using System;
using System.Collections.Generic;
using System.Data.Entity;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Initializers
{
    public class RecreateAlways : IDatabaseInitializer<TestContext>
    {
        public void InitializeDatabase(TestContext context)
        {
            context.Database.Delete();
            context.Database.Create();
            try
            {
                context.SaveChanges();
                Seed(context);
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Seed(TestContext context)
        {
            new List<Question>()
            {
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
                new Question {Description = "Edit text."},
            }.ForEach(e => context.Questions.Add(e));

            context.SaveChanges();

            foreach (var question in context.Questions)
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
