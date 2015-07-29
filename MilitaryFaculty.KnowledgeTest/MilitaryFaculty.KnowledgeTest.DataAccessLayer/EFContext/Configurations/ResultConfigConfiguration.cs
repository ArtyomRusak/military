using System.Data.Entity.ModelConfiguration;
using MilitaryFaculty.KnowledgeTest.Entities.Entities;

namespace MilitaryFaculty.KnowledgeTest.DataAccessLayer.EFContext.Configurations
{
    public class ResultConfigConfiguration : EntityTypeConfiguration<ResultConfig>
    {
        public ResultConfigConfiguration()
        {
            HasKey(mod => mod.Id);
            HasMany(mod => mod.Tests).WithOptional(mod => mod.ResultConfig);
        }
    }
}