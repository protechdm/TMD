using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class SubscriptionType
    {
        public virtual int SubscriptionTypeID { get; set; }
        public virtual string SubscriptionTypeName { get; set; }
        public virtual List<SubscriptionTypeItem> SubscriptionTypeItems { get; set; }
        public virtual WorkflowStatus SubscriptionTypeWorkflowStatus { get; set; }
        public virtual DataStatus SubscriptionTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
