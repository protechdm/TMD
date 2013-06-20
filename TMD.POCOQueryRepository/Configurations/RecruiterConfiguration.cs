using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class RecruiterConfiguration : EntityTypeConfiguration<Recruiter>
    {
        public RecruiterConfiguration()
        {
            ToTable("Recruiters");
            //Property(d => d.DeviceName).IsRequired();
            //Property(d => d.DeviceName).HasMaxLength(105);
            //Property(d => d.DeviceStatus).IsRequired();
            //this.HasRequired(x => x.DeviceStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
