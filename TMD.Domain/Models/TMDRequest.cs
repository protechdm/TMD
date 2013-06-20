using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region TMDRequest
    public class TMDRequest
    {
        public virtual int TMDRequestID { get; set; }
        public virtual int PersonID { get; set; }
        //public virtual int CloudApplicationID { get; set; }
        //public virtual bool? FreeTrial { get; set; }
        //public virtual bool? BuyNow { get; set; }
        public virtual int RequestTypeID { get; set; }
        public virtual bool? EMail { get; set; }
        public virtual DateTime? Serviced { get; set; }
        public virtual WorkflowStatus TMDRequestWorkflowStatus { get; set; }
        public virtual DataStatus TMDRequestDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
