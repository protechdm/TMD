using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class ContractType
    {
        public virtual int ContractTypeID { get; set; }
        public virtual string ContractTypeName { get; set; }
        public virtual WorkflowStatus ContractTypeWorkflowStatus { get; set; }
        public virtual DataStatus ContractTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
