using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class MarketingSpecialismConfiguration : EntityTypeConfiguration<MarketingSpecialism>
    {
        public MarketingSpecialismConfiguration()
        {
            ToTable("MarketingSpecialisms");
            //Property(d => d.CloudApplicationReviewDate).IsRequired();
            //Property(d => d.CloudApplicationReviewPublisherName).HasMaxLength(105);
            //Property(d => d.CloudApplicationUserReviewStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationUserReviewStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
