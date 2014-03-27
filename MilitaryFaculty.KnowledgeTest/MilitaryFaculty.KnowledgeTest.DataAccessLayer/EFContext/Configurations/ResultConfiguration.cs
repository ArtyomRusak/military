using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    public class ResultConfiguration : EntityTypeConfiguration<Result>
    {
        public ResultConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Mark).IsRequired();
            Property(e => e.Date).IsRequired();
            HasRequired(e => e.Student).WithMany(e => e.Results).HasForeignKey(e => e.StudentId);
        }
    }
}
