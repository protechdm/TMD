using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            ToTable("Addresses");
            //Property(d => d.AdvertisingImageTypeName).IsRequired();
            //Property(d => d.AdvertisingImageTypeName).HasMaxLength(105);
            //Property(d => d.AdvertisingImageTypeStatus).IsRequired();
            //this.HasRequired(x => x.AdvertisingImageTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
