using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region RequestType
    public class RequestType
    {
        public virtual int RequestTypeID { get; set; }
        public virtual string RequestTypeName { get; set; }
        public virtual WorkflowStatus RequestTypeWorkflowStatus { get; set; }
        public virtual DataStatus RequestTypeDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
