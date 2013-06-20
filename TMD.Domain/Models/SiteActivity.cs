using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class SiteActivity
    {
        public virtual int SiteActivityID { get; set; }
        public virtual List<SiteActivityType> SiteActivities { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Recruiter Recruiter { get; set; }
        public virtual WorkflowStatus SiteActivityWorkflowStatus { get; set; }
        public virtual DataStatus SiteActivityDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
