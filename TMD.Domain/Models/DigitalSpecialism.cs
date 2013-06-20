using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class DigitalSpecialism
    {
        public virtual int DigitalSpecialismID { get; set; }
        public virtual string DigitalSpecialismName { get; set; }
        public virtual WorkflowStatus DigitalSpecialismWorkflowStatus { get; set; }
        public virtual DataStatus DigitalSpecialismDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
