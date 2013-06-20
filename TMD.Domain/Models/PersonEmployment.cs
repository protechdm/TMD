using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class PersonEmployment
    {
        public virtual int PersonEmploymentID { get; set; }
        public virtual int PersonID { get; set; }
        public virtual bool IsCurrent { get; set; }
        public virtual Company Company { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual WorkflowStatus PersonEmploymentWorkflowStatus { get; set; }
        public virtual DataStatus PersonEmploymentDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
