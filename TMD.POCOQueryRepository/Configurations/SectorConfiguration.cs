using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class SectorConfiguration : EntityTypeConfiguration<Sector>
    {
        public SectorConfiguration()
        {
            ToTable("Sectors");
            //Property(d => d.MobilePlatformName).IsRequired();
            //Property(d => d.MobilePlatformName).HasMaxLength(105);
            //Property(d => d.MobilePlatformStatus).IsRequired();
            //this.HasRequired(x => x.MobilePlatformStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
