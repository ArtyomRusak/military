using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
