using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class SubscriptionTypeItemConfiguration : EntityTypeConfiguration<SubscriptionTypeItem>
    {
        public SubscriptionTypeItemConfiguration()
        {
            ToTable("SubscriptionTypeItems");
            //Property(d => d.PaymentOptionName).IsRequired();
            //Property(d => d.PaymentOptionName).HasMaxLength(105);
            //Property(d => d.PaymentOptionStatus).IsRequired();
            //this.HasRequired(x => x.PaymentOptionStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
