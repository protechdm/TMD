using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class DayRate
    {
        public virtual int DayRateID { get; set; }
        public virtual string DayRateName { get; set; }
        public virtual Currency DayRateCurrency { get; set; }
        public virtual WorkflowStatus DayRateWorkflowStatus { get; set; }
        public virtual DataStatus CurrencyDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
