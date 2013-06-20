using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region Salary
    public class Salary
    {
        public virtual int SalaryID { get; set; }
        public virtual string SalaryName { get; set; }
        public virtual int SalaryFrom { get; set; }
        public virtual int SalaryTo { get; set; }
        //public virtual bool IgnoreFilterPredicate { get; set; }
        public virtual WorkflowStatus SalaryWorkflowStatus { get; set; }
        public virtual DataStatus SalaryDataStatus { get; set; }
        //public virtual List<CloudApplication> CloudApplications { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
