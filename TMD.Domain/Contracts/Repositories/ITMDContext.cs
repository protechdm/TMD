using System;
using System.Data.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using TMD.Domain.Models;

namespace TMD.Domain.Contracts.Repositories
{
    public interface ITMDContext : IDisposable
    {
        IDbSet<Account> Accounts { get; }
        IDbSet<Address> Addresses { get; }
        IDbSet<BusinessType> BusinessTypes { get; }
        IDbSet<Candidate> Candidates { get; }
        IDbSet<Company> Companies { get; }
        IDbSet<ContractType> ContractTypes { get; }
        IDbSet<Country> Countries { get; }
        IDbSet<Currency> Currencies { get; }
        IDbSet<DataStatus> DataStatuses { get; }
        IDbSet<DayRate> DayRates { get; }
        IDbSet<DigitalSpecialism> DigitalSpecialisms { get; }
        IDbSet<Eligibility> Eligibilities { get; }
        IDbSet<FreeTrialPeriod> FreeTrialPeriods { get; }
        IDbSet<JobTitle> JobTitles { get; }
        IDbSet<JobType> JobTypes { get; }
        IDbSet<Language> Languages { get; }
        IDbSet<Location> Locations { get; }
        IDbSet<MarketingSpecialism> MarketingSpecialisms { get; }
        IDbSet<Package> Packages { get; }
        IDbSet<Person> Persons { get; }
        IDbSet<PersonEmployment> PersonEmployments { get; }
        IDbSet<PersonType> PersonTypes { get; }
        IDbSet<Recruiter> Recruiters { get; }
        IDbSet<RecruiterCandidate> RecruiterCandidates { get; }
        IDbSet<RecruiterCandidateHistoryItem> RecruiterCandidateHistoryItems { get; }
        IDbSet<RecruiterCandidateHistory> RecruiterCandidateHistory { get; }
        IDbSet<RecruiterShortlist> RecruiterShortlists { get; }
        IDbSet<ReLocate> ReLocates { get; }
        IDbSet<Request> Requests { get; }
        IDbSet<RequestType> RequestTypes { get; }
        IDbSet<Role> Roles { get; }
        IDbSet<Salary> Salaries { get; }
        IDbSet<Sector> Sectors { get; }
        IDbSet<SiteActivity> SiteActivities { get; }
        IDbSet<SiteActivityType> SiteActivityTypes { get; }
        IDbSet<Subscription> Subscriptions { get; }
        IDbSet<SubscriptionType> SubscriptionTypes { get; }
        IDbSet<SubscriptionTypeItem> SubscriptionTypeItems { get; }
        IDbSet<TechnologyCategory> TechnologyCategories { get; }
        IDbSet<TMDRequest> TMDRequests { get; }
        IDbSet<WorkflowStatus> WorkflowStatuses { get; }
        int SaveChanges();

        ObjectContext ObjectContext();

    }
}
