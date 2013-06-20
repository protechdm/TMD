using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using TMD.Domain.Models;
using TMD.Domain.Contracts.Repositories;
using TMD.POCOQueryRepository.Configurations;

using System.Data.Objects;
using System.Data.Entity.Infrastructure;

namespace TMD.POCOQueryRepository
{
    public class TMDContext : DbContext, ITMDContext
    {
        public IDbSet<Account> Accounts { get; set; }
        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<BusinessType> BusinessTypes { get; set; }
        public IDbSet<Candidate> Candidates { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<ContractType> ContractTypes { get; set; }
        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Currency> Currencies { get; set; }
        public IDbSet<DataStatus> DataStatuses { get; set; }
        public IDbSet<DayRate> DayRates { get; set; }
        public IDbSet<DigitalSpecialism> DigitalSpecialisms { get; set; }
        public IDbSet<Eligibility> Eligibilities { get; set; }
        public IDbSet<FreeTrialPeriod> FreeTrialPeriods { get; set; }
        public IDbSet<JobTitle> JobTitles { get; set; }
        public IDbSet<JobType> JobTypes { get; set; }
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<Location> Locations { get; set; }
        public IDbSet<MarketingSpecialism> MarketingSpecialisms { get; set; }
        public IDbSet<Package> Packages { get; set; }
        public IDbSet<Person> Persons { get; set; }
        public IDbSet<PersonEmployment> PersonEmployments { get; set; }
        public IDbSet<PersonType> PersonTypes { get; set; }
        public IDbSet<Recruiter> Recruiters { get; set; }
        public IDbSet<RecruiterCandidate> RecruiterCandidates { get; set; }
        public IDbSet<RecruiterCandidateHistoryItem> RecruiterCandidateHistoryItems { get; set; }
        public IDbSet<RecruiterCandidateHistory> RecruiterCandidateHistory { get; set;  }
        public IDbSet<RecruiterShortlist> RecruiterShortlists { get; set; }
        public IDbSet<ReLocate> ReLocates { get; set; }
        public IDbSet<Request> Requests { get; set; }
        public IDbSet<RequestType> RequestTypes { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<Salary> Salaries { get; set; }
        public IDbSet<Sector> Sectors { get; set; }
        public IDbSet<SiteActivity> SiteActivities { get; set; }
        public IDbSet<SiteActivityType> SiteActivityTypes { get; set; }
        public IDbSet<Subscription> Subscriptions { get; set; }
        public IDbSet<SubscriptionType> SubscriptionTypes { get; set; }
        public IDbSet<SubscriptionTypeItem> SubscriptionTypeItems { get; set; }
        public IDbSet<TechnologyCategory> TechnologyCategories { get; set; }
        public IDbSet<TMDRequest> TMDRequests { get; set; }
        public IDbSet<WorkflowStatus> WorkflowStatuses { get; set; }

        public TMDContext()
            : base()
        {

        }

        public TMDContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<TMDContext>(null);
            Database.SetInitializer(new DropCreateDatabaseAlways<TMDContext>());

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new BusinessTypeConfiguration());
            modelBuilder.Configurations.Add(new CandidateConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new ContractTypeConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new DataStatusConfiguration());
            modelBuilder.Configurations.Add(new DayRateConfiguration());
            modelBuilder.Configurations.Add(new DigitalSpecialismConfiguration());
            modelBuilder.Configurations.Add(new EligibilityConfiguration());
            modelBuilder.Configurations.Add(new FreeTrialPeriodConfiguration());
            modelBuilder.Configurations.Add(new JobTitleConfiguration());
            modelBuilder.Configurations.Add(new JobTypeConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new MarketingSpecialismConfiguration());
            modelBuilder.Configurations.Add(new PackageConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PersonTypeConfiguration());
            modelBuilder.Configurations.Add(new RecruiterCandidateConfiguration());
            modelBuilder.Configurations.Add(new RecruiterCandidateHistoryItemConfiguration());
            modelBuilder.Configurations.Add(new RecruiterCandidateHistoryConfiguration());
            modelBuilder.Configurations.Add(new RecruiterConfiguration());
            modelBuilder.Configurations.Add(new RecruiterShortlistConfiguration());
            modelBuilder.Configurations.Add(new ReLocateConfiguration());
            modelBuilder.Configurations.Add(new RequestConfiguration());
            modelBuilder.Configurations.Add(new RequestTypeConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new SalaryConfiguration());
            modelBuilder.Configurations.Add(new SectorConfiguration());
            modelBuilder.Configurations.Add(new SiteActivityConfiguration());
            modelBuilder.Configurations.Add(new SiteActivityTypeConfiguration());
            modelBuilder.Configurations.Add(new SubscriptionConfiguration());
            modelBuilder.Configurations.Add(new SubscriptionTypeConfiguration());
            modelBuilder.Configurations.Add(new SubscriptionTypeItemConfiguration());
            modelBuilder.Configurations.Add(new TechnologyCategoryConfiguration());
            modelBuilder.Configurations.Add(new TMDRequestConfiguration());
            modelBuilder.Configurations.Add(new WorkflowStatusConfiguration());

            //modelBuilder.Ignore<SearchResult>();
            //modelBuilder.Ignore<TabbedSearchResults>();
            //modelBuilder.Ignore<SimpleSearchInputs>();
            //modelBuilder.Ignore<TagResult>();

            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<CloudApplication>().HasRequired(x => x.CloudApplicationStatus).WithRequiredDependent().WillCascadeOnDelete(false);
            //SimpleSearchInputs.Include(x => x.Categories);
            //this.Configuration.ProxyCreationEnabled = false;
            //this.Configuration.LazyLoadingEnabled = false;
        }

        //public CloudApplication FindById(int cloudApplicationId)
        //{
        //    return CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationId).SingleOrDefault();
        //}

        //IDbSet<CloudApplication> ICloudCompareContext.CloudApplications
        //{
        //    get { return CloudApplications; }
        //}

        //IDbSet<Vendor> ICloudCompareContext.Vendors
        //{
        //    get { return Vendors; }
        //}

        //IDbSet<Feature> ICloudCompareContext.Features
        //{
        //    get { return Features; }
        //}

        public ObjectContext ObjectContext()
        {
            return (this as IObjectContextAdapter).ObjectContext;
        }
    }
}
