using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    internal class VariantConfiguration : EntityTypeConfiguration<Variant>
    {
        public VariantConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Description).IsRequired();
            Property(e => e.IsRight).IsRequired();
            HasRequired(e => e.Question).WithMany(e => e.Variants).HasForeignKey(e => e.QuestionId);
        }
    }
}
