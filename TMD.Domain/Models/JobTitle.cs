using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class JobTitle
    {
        public virtual int JobTitleID { get; set; }
        public virtual string JobTitleName { get; set; }
        public virtual WorkflowStatus JobTitleWorkflowStatus { get; set; }
        public virtual DataStatus JobTitleDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
