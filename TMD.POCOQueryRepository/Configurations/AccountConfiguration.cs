using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            ToTable("Accounts");
            //Property(d => d.AdvertisingImageFileName).IsRequired();
            //Property(d => d.AdvertisingImageFileName).HasMaxLength(105);
            //Property(d => d.AdvertisingImageStatus).IsRequired();
            //this.HasRequired(x => x.AdvertisingImageStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
