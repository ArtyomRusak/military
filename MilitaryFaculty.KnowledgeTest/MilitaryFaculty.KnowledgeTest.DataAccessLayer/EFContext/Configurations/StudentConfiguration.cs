using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    internal class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Name).HasMaxLength(20).IsRequired();
            Property(e => e.Surname).HasMaxLength(40).IsRequired();
            Property(e => e.Platoon).IsRequired();
            HasMany(e => e.Results).WithRequired(e => e.Student).HasForeignKey(e => e.StudentId);
        }
    }
}
