using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class RecruiterShortlist
    {
        public virtual int RecruiterShortlistID { get; set; }
        public virtual string RecruiterShortlistName { get; set; }
        public virtual Recruiter Recruiter { get; set; }
        public virtual List<Candidate> Candidates { get; set; }
        public virtual WorkflowStatus RecruiterShortlistWorkflowStatus { get; set; }
        public virtual DataStatus RecruiterShortlistDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
