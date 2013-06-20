using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Sector
    {
        public virtual int SectorID { get; set; }
        public virtual string SectorName { get; set; }
        public virtual WorkflowStatus SectorWorkflowStatus { get; set; }
        public virtual DataStatus SectorDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
