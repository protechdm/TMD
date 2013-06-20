using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class JobType
    {
        public virtual int JobTypeID { get; set; }
        public virtual string JobTypeName { get; set; }
        public virtual WorkflowStatus JobTypeWorkflowStatus { get; set; }
        public virtual DataStatus JobTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
