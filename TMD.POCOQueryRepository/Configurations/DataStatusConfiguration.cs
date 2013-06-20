using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class DataStatusConfiguration : EntityTypeConfiguration<DataStatus>
    {
        public DataStatusConfiguration()
        {
            ToTable("DataStatuses");
            //Property(d => d.CloudApplicationDocumentTitle).IsRequired();
            //Property(d => d.CloudApplicationDocumentTitle).HasMaxLength(105);
            //Property(d => d.CloudApplicationDocumentStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationDocumentStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
