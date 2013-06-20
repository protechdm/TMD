using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Recruiter
    {
        public virtual int RecruiterID { get; set; }
        public virtual Person Person { get; set; }
        public virtual List<PersonEmployment> Employments { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual WorkflowStatus RecruiterWorkflowStatus { get; set; }
        public virtual DataStatus RecruiterDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
