using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class SiteActivityTypeConfiguration : EntityTypeConfiguration<SiteActivityType>
    {
        public SiteActivityTypeConfiguration()
        {
            ToTable("SiteActivityTypes");
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
