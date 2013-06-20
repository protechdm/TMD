using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class DayRateConfiguration : EntityTypeConfiguration<DayRate>
    {
        public DayRateConfiguration()
        {
            ToTable("DayRates");
            //Property(d => d.CloudApplicationDocumentFormatShortName).IsRequired();
            //Property(d => d.CloudApplicationDocumentFormatShortName).HasMaxLength(10);
            //Property(d => d.CloudApplicationDocumentFormatStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationDocumentFormatStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
