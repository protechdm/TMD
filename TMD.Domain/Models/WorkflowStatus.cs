using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region WorkflowStatus
    public class WorkflowStatus
    {
        public virtual int WorkflowStatusID { get; set; }
        public virtual string WorkflowStatusName { get; set; }
        //public virtual DataStatus WorkflowStatusDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
