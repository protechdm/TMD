using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data.Entity;
using TMD.Domain.Models;
using TMD.Domain.Contracts.Repositories;
using LinqKit;
//using TMD.POCOQueryRepository.Helpers;
using TMD.POCOQueryRepository.Caching;
using System.Configuration;
using TMD.SocialNetworking;


using System.Data.Entity.Infrastructure;

namespace TMD.POCOQueryRepository
{
    public class QueryRepository : BaseRepository, ITMDRepository, IDisposable
    {
        const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_FEATURES = "FEATURES";
        const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURES";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_DEVICES = "DEVICES";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";
        const string FILTER_TIMEZONES = "TIMEZONES";

        ITMDContext _context;

        public ICacheProvider Cache { get; set; }

        #region Constructors
        //public QueryRepository()
        //{
        //    _context = new CloudCompareContext();
        //}

        public QueryRepository(ITMDContext context)
            : base(context as TMDContext)
        {
            _context = context;
        }

        public QueryRepository(TMDContext context)
            : base(context)
        {
            _context = context;
        }

        public QueryRepository(ITMDContext context, ICacheProvider cacheProvider)
            : base(context as TMDContext)
        {
            _context = context;
            this.Cache = cacheProvider;
        }


        #endregion

        #region Save
        public string Save()
        {
            string validationErrors = "";
            if (PreSavingValidations(out validationErrors) == true)
            {
                //this Save is not taking n-tier issues into account
                _context.SaveChanges();
                return "";
            }
            else
                return "Data Not Saved due to Validation Errors: " + validationErrors;
        }
        #endregion

        #region PreSavingValidations
        public bool PreSavingValidations(out string validationErrors)
        {
            bool isvalid = true;
            validationErrors = "";

            //foreach (Reservation res in _context.ManagedReservations)
            //{
            //    try
            //    {
            //        bool isResValid;
            //        string validationError;
            //        isResValid = res.ValidateBeforeSave(out validationError);
            //        if (!isResValid)
            //        {
            //            isvalid = false;
            //            validationErrors += validationError;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            return isvalid;
        }
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ClearCache()
        {
            Cache.Invalidate("vehicles");
        }


        public bool AddStatus(DataStatus s)
        {
            _context.DataStatuses.Add(s);
            return true;
        }
    }


}
