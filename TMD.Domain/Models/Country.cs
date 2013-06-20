using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Country
    {
        public virtual int CountryID { get; set; }
        public virtual string CountryName { get; set; }
        public virtual WorkflowStatus CountryWorkflowStatus { get; set; }
        public virtual DataStatus CountryDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
