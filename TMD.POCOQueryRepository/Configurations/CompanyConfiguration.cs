using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations

{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            ToTable("Companies");
            //Property(d => d.SearchResultsAnnualPriceColumnHeader).IsRequired();
            //Property(d => d.SearchResultsMonthlyPriceColumnHeader).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
