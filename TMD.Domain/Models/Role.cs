using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Role
    {
        public virtual int RoleID { get; set; }
        public virtual string RoleName { get; set; }
        public virtual WorkflowStatus RoleWorkflowStatus { get; set; }
        public virtual DataStatus RoleDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
