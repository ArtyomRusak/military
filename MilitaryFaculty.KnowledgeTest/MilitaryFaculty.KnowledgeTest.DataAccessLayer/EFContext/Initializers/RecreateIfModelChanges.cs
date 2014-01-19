using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Transactions;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Initializers
{
    public class RecreateIfModelChanges : IDatabaseInitializer<TestContext>
    {
        #region Implementation of IDatabaseInitializer<in TestContext>

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

        #endregion

        #region [RecreateIfModelChanges's members]

        protected void Seed(TestContext context)
        {
            new List<Question>()
            {
                new Question() {Id = Guid.NewGuid(), Description = "Edit text."}
            }.ForEach(e => context.Questions.Add(e));

            foreach (var question in context.Questions)
            {
                new List<Variant>()
                {
                    new Variant() {Id = Guid.NewGuid(), QuestionId = question.Id, IsRight = false},
                    new Variant() {Id = Guid.NewGuid(), QuestionId = question.Id, IsRight = false},
                    new Variant() {Id = Guid.NewGuid(), QuestionId = question.Id, IsRight = false},
                    new Variant() {Id = Guid.NewGuid(), QuestionId = question.Id, IsRight = false},
                    new Variant() {Id = Guid.NewGuid(), QuestionId = question.Id, IsRight = false},
                }.ForEach(e => context.Variants.Add(e));
            }

            context.SaveChanges();
        }

        #endregion
    }
}
