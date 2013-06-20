using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Address
    {
        public virtual int AddressID { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string Region { get; set; }
        public virtual string Country { get; set; }
        public virtual string PostCode { get; set; }
        public virtual WorkflowStatus AddressWorkflowStatus { get; set; }
        public virtual DataStatus AddressDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
