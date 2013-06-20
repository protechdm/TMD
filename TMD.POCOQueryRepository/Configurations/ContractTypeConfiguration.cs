using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class ContractTypeConfiguration : EntityTypeConfiguration<ContractType>
    {
        public ContractTypeConfiguration()
        {
            ToTable("ContractTypes");
            //Property(d => d.FeatureName).IsRequired();
            //Property(d => d.FeatureName).HasMaxLength(105);
            //HasOptional(p => p.Feature);
            //Property(d => d.CloudApplicationApplicationStatus).IsRequired();
            //this.HasRequired(x => x.CloudApplicationApplicationStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
