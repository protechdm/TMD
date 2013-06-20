using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class ReLocateConfiguration : EntityTypeConfiguration<ReLocate>
    {
        public ReLocateConfiguration()
        {
            ToTable("ReLocates");
            //Property(d => d.Code).IsRequired();
            //Property(d => d.Description).IsRequired();
            //Property(d => d.IndustryStatus).IsRequired();
            //this.HasRequired(x => x.IndustryStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
