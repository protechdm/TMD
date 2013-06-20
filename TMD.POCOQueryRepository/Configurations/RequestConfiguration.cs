using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class RequestConfiguration : EntityTypeConfiguration<Request>
    {
        public RequestConfiguration()
        {
            ToTable("Requests");
            //Property(d => d.RequestTypeName).IsRequired();
            //Property(d => d.RequestTypeStatus).IsRequired();
            //this.HasRequired(x => x.RequestTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
