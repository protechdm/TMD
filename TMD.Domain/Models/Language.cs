using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region Language
    public class Language
    {
        public virtual int LanguageID { get; set; }
        public virtual string LanguageName { get; set; }
        public virtual WorkflowStatus LanguageWorkflowStatus { get; set; }
        public virtual DataStatus LanguageDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
