using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class RecruiterCandidate
    {
        public virtual int RecruiterCandidateID { get; set; }
        public virtual int RecruiterID { get; set; }
        public virtual int CandidateID { get; set; }
        public virtual DateTime RecruiterCandidateDate { get; set; }
        public virtual WorkflowStatus RecruiterCandidateWorkflowStatus { get; set; }
        public virtual Person RecruiterCandidateAssignedTo { get; set; }
        public virtual DataStatus RecruiterCandidateDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
