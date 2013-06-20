using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class TMDRequestConfiguration : EntityTypeConfiguration<TMDRequest>
    {
        public TMDRequestConfiguration()
        {
            ToTable("TMDRequests");
            //Property(d => d.SetupFeeName).IsRequired();
            //Property(d => d.SetupFeeName).HasMaxLength(105);
            //Property(d => d.SetupFeeStatus).IsRequired();
            //this.HasRequired(x => x.SetupFeeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
