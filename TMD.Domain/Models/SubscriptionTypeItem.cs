using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class SubscriptionTypeItem
    {
        public virtual int SubscriptionTypeItemID { get; set; }
        public virtual string SubscriptionTypeItemName { get; set; }
        public virtual WorkflowStatus SubscriptionTypeItemWorkflowStatus { get; set; }
        public virtual DataStatus SubscriptionTypeItemDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
