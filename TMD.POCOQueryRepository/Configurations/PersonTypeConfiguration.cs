using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class PersonTypeConfiguration : EntityTypeConfiguration<PersonType>
    {
        public PersonTypeConfiguration()
        {
            ToTable("PersonTypes");
            //Property(d => d.ContentTextTypeName).IsRequired();
            //Property(d => d.ContentTextTypeName).HasMaxLength(105);
            //Property(d => d.ContentTextTypeStatus).IsRequired();
            //this.HasRequired(x => x.ContentTextTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
