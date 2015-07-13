using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    public class TestConfiguration : EntityTypeConfiguration<Test>
    {
        public TestConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Name).IsRequired().HasMaxLength(50);
            HasMany(e => e.Questions).WithMany(e => e.Tests);
            HasRequired(mod => mod.TestConfig).WithRequiredPrincipal(mod => mod.Test);
        }
    }
}
