using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Eligibility
    {
        public virtual int EligibilityID { get; set; }
        public virtual string EligibilityName { get; set; }
        public virtual WorkflowStatus EligibilityWorkflowStatus { get; set; }
        public virtual DataStatus EligibilityDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
