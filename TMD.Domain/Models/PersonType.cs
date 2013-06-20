using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class PersonType
    {
        public virtual int PersonTypeID { get; set; }
        public virtual string PersonTypeName { get; set; }
        public virtual WorkflowStatus PersonTypeWorkflowStatus { get; set; }
        public virtual DataStatus PersonTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
