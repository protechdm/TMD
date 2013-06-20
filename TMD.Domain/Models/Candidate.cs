using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMD.Domain.Models
{
    public class Candidate
    {
        public virtual int CandidateID { get; set; }
        public virtual Person Person { get; set; }
        public virtual string CandidateSummary { get; set; }
        public virtual string CandidateReference { get; set; }
        public virtual decimal CandidateScoring { get; set; }
        public virtual DayRate CurrentDayRate { get; set; }

        public virtual List<PersonEmployment> Employments { get; set; }
        public virtual List<MarketingSpecialism> MarketingSpecialisms { get; set; }
        public virtual List<DigitalSpecialism> DigitalSpecialisms { get; set; }
        public virtual List<JobType> JobTypes { get; set; }
        public virtual Salary CurrentSalary { get; set; }
        public virtual List<Sector> SectorExperiences { get; set; }
        public virtual List<TechnologyCategory> TechnologyCategoryExperiences { get; set; }
        public virtual List<BusinessType> BusinessTypeExperiences { get; set; }
        public virtual List<Location> LocationsSought { get; set; }
        public virtual List<Country> Countries { get; set; }
        public virtual ReLocate WillingToRelocate { get; set; }
        public virtual Eligibility EligibilityToWorkIn { get; set; }
        public virtual List<Language> Languages { get; set; }
        public virtual List<ContractType> ContractTypes { get; set; }
        public virtual WorkflowStatus CandidateWorkflowStatus { get; set; }
        public virtual DataStatus CandidateDataStatus { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
