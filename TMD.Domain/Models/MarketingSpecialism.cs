using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class MarketingSpecialism
    {
        public virtual int MarketingSpecialismID { get; set; }
        public virtual string MarketingSpecialismName { get; set; }
        public virtual WorkflowStatus MarketingSpecialismWorkflowStatus { get; set; }
        public virtual DataStatus MarketingSpecialismDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
