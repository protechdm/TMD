using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region FreeTrialPeriod
    public class FreeTrialPeriod
    {
        public virtual int FreeTrialPeriodID { get; set; }
        public virtual string FreeTrialPeriodName { get; set; }
        public virtual Recruiter FreeTrialPeriodRecruiter { get; set; }
        public virtual WorkflowStatus FreeTrialPeriodWorkflowStatus { get; set; }
        public virtual DataStatus FreeTrialPeriodDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
