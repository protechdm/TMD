using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class SiteActivityType
    {
        public virtual int SiteActivityTypeID { get; set; }
        public virtual string SiteActivityTypeName { get; set; }
        public virtual WorkflowStatus SiteActivityTypeWorkflowStatus { get; set; }
        public virtual DataStatus SiteActivityTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
