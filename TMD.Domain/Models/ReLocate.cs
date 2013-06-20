using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class ReLocate
    {
        public virtual int ReLocateID { get; set; }
        public virtual string ReLocateName { get; set; }
        public virtual WorkflowStatus ReLocateWorkflowStatus { get; set; }
        public virtual DataStatus ReLocateDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
