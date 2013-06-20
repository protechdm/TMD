using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Request
    {
        public virtual int RequestID { get; set; }
        public virtual string RequestName { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual RecruiterShortlist RecruiterShortlist { get; set; }
        public virtual WorkflowStatus RequestTypeWorkflowStatus { get; set; }
        public virtual DataStatus RequestTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
