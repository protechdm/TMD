using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class TechnologyCategory
    {
        public virtual int TechnologyCategoryID { get; set; }
        public virtual string TechnologyCategoryName { get; set; }
        public virtual WorkflowStatus TechnologyCategoryWorkflowStatus { get; set; }
        public virtual DataStatus TechnologyCategoryDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
