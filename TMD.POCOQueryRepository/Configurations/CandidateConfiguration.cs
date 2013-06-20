using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations

{
    public class CandidateConfiguration : EntityTypeConfiguration<Candidate>
    {
        public CandidateConfiguration()
        {
            ToTable("Candidates");
            //Property(d => d.CategoryName).IsRequired();
            //Property(d => d.CategoryName).HasMaxLength(105);
            //Property(d => d.CategoryStatus).IsRequired();
            //this.HasRequired(x => x.CategoryStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
