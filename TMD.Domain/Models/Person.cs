using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    #region Person
    public class Person
    {
        public virtual int PersonID { get; set; }
        public virtual string Forename { get; set; }
        public virtual string Surname { get; set; }
        public virtual string EMail { get; set; }
        public virtual string Telephone { get; set; }
        //public virtual string Company { get; set; }
        //public virtual int NumberOfEmployees { get; set; }
        //public virtual string Position { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual Address PersonAddress { get; set; }
        public virtual bool IsOnline { get; set; }
        public virtual DateTime? LastLoggedIn { get; set; }
        //public virtual bool? IsAdministrator { get; set; }
        //public virtual bool? IsEditor { get; set; }
        //public virtual bool? IsFinanceContact { get; set; }
        public virtual WorkflowStatus PersonWorkflowStatus { get; set; }
        public virtual DataStatus PersonDataStatus { get; set; }
        public virtual List<PersonType> PersonTypes { get; set; }
        public virtual List<Role> RoleTypes { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
