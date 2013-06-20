using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class SalaryConfiguration : EntityTypeConfiguration<Salary>
    {
        public SalaryConfiguration()
        {
            ToTable("Salaries");
            //Property(d => d.MinimumContractName).IsRequired();
            //Property(d => d.MinimumContractName).HasMaxLength(105);
            //Property(d => d.MinimumContractStatus).IsRequired();
            //this.HasRequired(x => x.MinimumContractStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
