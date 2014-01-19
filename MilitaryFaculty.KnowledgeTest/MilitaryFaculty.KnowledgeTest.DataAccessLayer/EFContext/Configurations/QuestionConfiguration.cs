using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    internal class QuestionConfiguration : EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Description).IsRequired();
            HasMany(e => e.Variants).WithRequired(e => e.Question).HasForeignKey(e => e.QuestionId);
        }
    }
}
