﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class BusinessTypeConfiguration : EntityTypeConfiguration<BusinessType>
    {
        public BusinessTypeConfiguration()
        {
            ToTable("BusinessTypes");
            //Property(d => d.BrowserName).IsRequired();
            //Property(d => d.BrowserName).HasMaxLength(105);
            //Property(d => d.BrowserStatus).IsRequired();
            //this.HasRequired(x => x.BrowserStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
