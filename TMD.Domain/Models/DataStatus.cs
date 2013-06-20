using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region DataStatus
    public class DataStatus
    {
        public virtual int DataStatusID { get; set; }
        public virtual string DataStatusName { get; set; }
        //public virtual WorkflowStatus DataStatusWorkflowStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
