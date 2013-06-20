using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Company
    {
        public virtual int CompanyID { get; set; }
        public virtual string CompanyEMail { get; set; }
        public virtual string CompanyTelephone { get; set; }
        public virtual Address CompanyAddress { get; set; }
        public virtual DateTime? LastLoggedIn { get; set; }

        public virtual WorkflowStatus CompanyWorkflowStatus { get; set; }
        public virtual DataStatus CompanyDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
