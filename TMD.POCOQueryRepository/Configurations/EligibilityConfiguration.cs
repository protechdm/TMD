using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class EligibilityConfiguration : EntityTypeConfiguration<Eligibility>
    {
        public EligibilityConfiguration()
        {
            ToTable("Eligibilities");
            //Property(d => d.CloudApplicationDocumentTypeName).IsRequired();
            //Property(d => d.CloudApplicationDocumentTypeName).HasMaxLength(105);
            //Property(d => d.CloudApplicationDocumentTypeStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationDocumentTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
