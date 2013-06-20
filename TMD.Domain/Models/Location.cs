using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Location
    {
        public virtual int LocationID { get; set; }
        public virtual string LocationName { get; set; }
        public virtual WorkflowStatus LocationWorkflowStatus { get; set; }
        public virtual DataStatus LocationDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
