using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class JobTitleConfiguration : EntityTypeConfiguration<JobTitle>
    {
        public JobTitleConfiguration()
        {
            ToTable("JobTitles");
            //Property(d => d.FeatureName).IsRequired();
            //Property(d => d.FeatureName).HasMaxLength(105);
            //HasOptional(p => p.Feature);
            //Property(d => d.CloudApplicationFeatureStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationFeatureStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
