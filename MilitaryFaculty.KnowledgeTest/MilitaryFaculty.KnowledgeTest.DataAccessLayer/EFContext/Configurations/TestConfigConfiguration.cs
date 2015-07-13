using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    public class TestConfigConfiguration : EntityTypeConfiguration<TestConfig>
    {
        public TestConfigConfiguration()
        {
            HasKey(mod => mod.Id);
            Property(mod => mod.NumberOfQuestions).IsRequired();
            HasRequired(mod => mod.Test).WithRequiredDependent(mod => mod.TestConfig);
        }
    }
}