using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class BusinessType
    {
        public virtual int BusinessTypeID { get; set; }
        public virtual string BusinessTypeName { get; set; }
        public virtual WorkflowStatus BusinessTypeWorkflowStatus { get; set; }
        public virtual DataStatus BusinessTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
