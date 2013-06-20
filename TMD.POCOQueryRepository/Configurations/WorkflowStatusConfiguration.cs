using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.Configurations
{
    public class WorkflowStatusConfiguration : EntityTypeConfiguration<WorkflowStatus>
    {
        public WorkflowStatusConfiguration()
        {
            ToTable("WorkflowStatuses");
            //Property(d => d.SupportDaysName).IsRequired();
            //Property(d => d.SupportDaysName).HasMaxLength(105);
            //Property(d => d.SupportDaysStatus).IsRequired();
            //this.HasRequired(x => x.SupportDaysStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
