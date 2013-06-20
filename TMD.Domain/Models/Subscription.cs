using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Subscription
    {
        public virtual int SubscriptionID { get; set; }
        public virtual bool SubscriptionCostPerUserOffered { get; set; }
        public virtual bool SubscriptionCostPerMultiUserOffered { get; set; }
        public virtual decimal SubscriptionCostPerUser { get; set; }
        public virtual decimal SubscriptionCostPerMultiUser { get; set; }
        public virtual WorkflowStatus SubscriptionWorkflowStatus { get; set; }
        public virtual DataStatus SubscriptionDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
