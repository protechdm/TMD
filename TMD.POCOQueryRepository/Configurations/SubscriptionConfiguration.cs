using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class SubscriptionConfiguration : EntityTypeConfiguration<Subscription>
    {
        public SubscriptionConfiguration()
        {
            ToTable("Subscriptions");
            //Property(d => d.OperatingSystemName).IsRequired();
            //Property(d => d.OperatingSystemName).HasMaxLength(105);
            //Property(d => d.OperatingSystemStatus).IsRequired();
            //this.HasRequired(x => x.OperatingSystemStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
