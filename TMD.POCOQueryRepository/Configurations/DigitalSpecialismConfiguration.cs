using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class DigitalSpecialismConfiguration : EntityTypeConfiguration<DigitalSpecialism>
    {
        public DigitalSpecialismConfiguration()
        {
            ToTable("DigitalSpecialisms");
            //Property(d => d.CloudApplicationDocumentBytes).IsRequired();
            //Property(d => d.ThumbnailDocumentTitle).HasMaxLength(105);
            //Property(d => d.CloudApplicationDocumentImageStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationDocumentImageStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
