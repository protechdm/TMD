using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class JobTypeConfiguration : EntityTypeConfiguration<JobType>
    {
        public JobTypeConfiguration()
        {
            ToTable("JobTypes");
            //Property(d => d.CloudApplicationProductReviewDate).IsRequired();
            //Property(d => d.CloudApplicationProductReviewPublisherName).HasMaxLength(105);
            //Property(d => d.CloudApplicationProductReviewText).HasMaxLength(1000);
            //Property(d => d.CloudApplicationProductReviewStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationProductReviewStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
