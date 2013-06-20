using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region Currency
    public class Currency
    {
        public virtual int CurrencyID { get; set; }
        public virtual string CurrencyShortName { get; set; }
        public virtual string CurrencyName { get; set; }
        public virtual string CurrencySymbol { get; set; }
        public virtual decimal ExchangeRateSterling { get; set; }

        public virtual WorkflowStatus CurrencyWorkflowStatus { get; set; }
        public virtual DataStatus CurrencyDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
