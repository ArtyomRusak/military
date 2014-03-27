﻿using System.Data.Entity;
using MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext
{
    public class TestContext : DbContext
    {
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Security> Security { get; set; }
        public DbSet<Result> Results { get; set; }

        public TestContext(string connectionstring)
            : base(connectionstring)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VariantConfiguration());
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new SecurityConfiguration());
            modelBuilder.Configurations.Add(new ResultConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
