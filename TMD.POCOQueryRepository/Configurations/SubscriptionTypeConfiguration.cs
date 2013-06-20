using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class SubscriptionTypeConfiguration : EntityTypeConfiguration<SubscriptionType>
    {
        public SubscriptionTypeConfiguration()
        {
            ToTable("SubscriptionTypes");
            //Property(d => d.PaymentFrequencyName).IsRequired();
            //Property(d => d.PaymentFrequencyName).HasMaxLength(105);
            //Property(d => d.PaymentFrequencyStatus).IsRequired();
            //this.HasRequired(x => x.PaymentFrequencyStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
