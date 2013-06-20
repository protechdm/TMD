using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class PersonEmploymentConfiguration : EntityTypeConfiguration<PersonEmployment>
    {
        public PersonEmploymentConfiguration()
        {
            ToTable("PersonEmployments");
            //Property(d => d.ContentTextData).IsRequired();
            //Property(d => d.NiceName).HasMaxLength(105);
            //Property(d => d.ContentTextStatus).IsRequired();
            //this.HasRequired(x => x.ContentTextStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
