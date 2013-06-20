﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class RequestTypeConfiguration : EntityTypeConfiguration<RequestType>
    {
        public RequestTypeConfiguration()
        {
            ToTable("RequestTypes");
            Property(d => d.RequestTypeName).IsRequired();
            //Property(d => d.RequestTypeStatus).IsRequired();
            //this.HasRequired(x => x.RequestTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
