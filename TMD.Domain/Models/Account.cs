using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Account
    {
        public virtual int AccountID { get; set; }
        public virtual List<Recruiter> AccountRecruiters { get; set; }
        public virtual Company AccountCompany { get; set; }
        public virtual DateTime AccountStartDate { get; set; }
        public virtual DateTime AccountRenewalDate { get; set; }
        public virtual Package AccountPackage { get; set; }
        public virtual int AccountIntroductionsLimit { get; set; }
        public virtual WorkflowStatus AccountWorkflowStatus { get; set; }
        public virtual DataStatus AccountDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
