using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class RecruiterCandidateHistory
    {
        public virtual int RecruiterCandidateHistoryID { get; set; }
        public virtual List<RecruiterCandidateHistoryItem> RecruiterCandidateHistoryItems { get; set; }
        public virtual WorkflowStatus RecruiterCandidateHistoriesWorkflowStatus { get; set; }
        public virtual DataStatus RecruiterCandidateHistoriesDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
