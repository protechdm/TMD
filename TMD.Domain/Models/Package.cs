using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Package
    {
        public virtual int PackageID { get; set; }
        public virtual string PackageName { get; set; }
        //public virtual string CurrentJobTitle { get; set; }
        //public virtual string CurrentEmployer { get; set; }
        //public virtual decimal CurrentSalary { get; set; }
        //public virtual decimal DayRate { get; set; }

        //public virtual List<MarketingSpecialism> MarketingSpecialisms { get; set; }
        //public virtual List<DigitalSpecialism> DigitalSpecialisms { get; set; }
        //public virtual List<JobType> JobTypes { get; set; }
        public virtual WorkflowStatus PackageWorkflowStatus { get; set; }
        public virtual DataStatus PackageDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
