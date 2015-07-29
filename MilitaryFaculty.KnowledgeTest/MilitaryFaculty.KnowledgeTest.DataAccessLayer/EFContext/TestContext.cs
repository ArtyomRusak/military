using System.Data.Entity;
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
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestConfig> TestConfigs { get; set; }
        public DbSet<ResultConfig> ResultConfigs { get; set; }

        public TestContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VariantConfiguration());
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new SecurityConfiguration());
            modelBuilder.Configurations.Add(new ResultConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new TestConfigConfiguration());
            modelBuilder.Configurations.Add(new ResultConfigConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
