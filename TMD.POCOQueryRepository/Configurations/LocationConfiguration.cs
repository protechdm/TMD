using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class LocationConfiguration : EntityTypeConfiguration<Location>
    {
        public LocationConfiguration()
        {
            ToTable("Locations");
            //Property(d => d.PersonID).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
