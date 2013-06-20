using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class RecruiterCandidateHistoryItem
    {
        public virtual int RecruiterCandidateHistoryItemID { get; set; }
        public virtual Recruiter RecruiterID { get; set; }
        public virtual Candidate CandidateID { get; set; }
        public virtual DateTime RecruiterCandidateHistoryItemDate { get; set; }
        public virtual WorkflowStatus RecruiterCandidateHistoryItemWorkflowStatus { get; set; }
        public virtual DataStatus RecruiterCandidateHistoryItemDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
