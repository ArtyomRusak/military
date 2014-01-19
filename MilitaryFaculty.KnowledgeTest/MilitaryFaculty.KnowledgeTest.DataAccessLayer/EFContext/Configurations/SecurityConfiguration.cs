using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    internal class SecurityConfiguration : EntityTypeConfiguration<Security>
    {
        public SecurityConfiguration()
        {
            HasKey(e => e.Id);
            Property(e => e.Password).IsRequired();
            Property(e => e.PasswordSalt).IsRequired();
        }
    }
}
