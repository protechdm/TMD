using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class RecruiterCandidateHistoryItemConfiguration : EntityTypeConfiguration<RecruiterCandidateHistoryItem>
    {
        public RecruiterCandidateHistoryItemConfiguration()
        {
            ToTable("RecruiterCandidateHistoryItems");
            //Property(d => d.FeatureTypeName).IsRequired();
            //Property(d => d.FeatureTypeName).HasMaxLength(105);
            //Property(d => d.FeatureTypeStatus).IsRequired();
            //this.HasRequired(x => x.FeatureTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
            
        }
    }
}
