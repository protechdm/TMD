using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("Roles");
            //Property(d => d.LicenceTypeMinimumName).IsRequired();
            //Property(d => d.LicenceTypeMinimumName).HasMaxLength(105);
            //Property(d => d.LicenceTypeMinimumStatus).IsRequired();
            //this.HasRequired(x => x.LicenceTypeMinimumStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }


}
