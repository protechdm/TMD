using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.Domain.Models;
using TMD.POCOQueryRepository;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

//using Microsoft.WindowsAPICodePack;
//using Microsoft.WindowsAPICodePack.Shell;
//using ManagedWinapi;
//using GhostscriptSharp;
using System.Configuration;

namespace TMD.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            string TEST_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf";
            string SINGLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string OUTPUT_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string MULTIPLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\output%d.jpg";
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CloudCompare.Domain.CloudCompareContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CloudCompareContext>());
            //InsertVendor();
            //LoadRatings();

            //using (var context = new CloudCompareContext())
            //{
            //    LoadTwitterFollowers(context);
            //    context.SaveChanges();
            //}

            //using (var context = new CloudCompareContext())
            //{
            //    LoadFacebookFans(context);
            //    context.SaveChanges();
            //}
            //ContentTextData();
            //return;

            StageData();
            LoadRatings();
            LoadApplicationWeightings();
            //LoadTwitterFollowers();
            //LoadFacebookFans();
            //LoadLinkedInFollowers();
            LoadVideos();
            //LoadStatuses();
            //long fans = CheckFacebookName("WebEx");
            //string outputFile = SINGLE_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg";
            //GetThumbnail("J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf");
            //var x = GhostscriptWrapper.GetPageThumb(TEST_FILE_LOCATION, outputFile, 3, 100, 100);
            LoadWhitePaperCaseStudyBytes();
        }

        #region InsertVendor
        //private static void InsertVendor()
        //{
        //    var vendor = new Vendor
        //    {
        //        VendorName = "XERO"
        //    };

        //    using (var context = new CompareCloudwareContext())
        //    {
        //        context.Vendors.Add(vendor);
        //        context.SaveChanges();
        //    }
        //}
        #endregion

        #region StageData
        private static void StageData()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new TMDContext();
            data.LoadFakeReferenceData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationErrors.Property, validationErrors.ErrorMessage);
                    }
                }
            }



            //data.LoadFakeProductionData(context);
            ////data.SetLiveStatuses(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}



            ////LoadRatings();
            ////LoadApplicationWeightings();
            ////LoadTwitterFollowers();
            ////LoadFacebookFans();


        }
        #endregion

        #region ContentTextData
        private static void ContentTextData()
        {
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            //data.LoadFakeContentTextData(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationErrors.Property, validationErrors.ErrorMessage);
            //        }
            //    }
            //}



        }
        #endregion

        #region LoadRatings
        private static void LoadRatings()
        {

            //Random r = new Random();
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.InsertRatings(context, r);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
        #endregion

        #region LoadStatuses
        private static void LoadStatuses()
        {

            //Random r = new Random();
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.SetLiveStatuses(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
        #endregion

        #region LoadApplicationWeightings
        private static void LoadApplicationWeightings()
        {

            //Random r = new Random();
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.InsertApplicationWeightings(context, r);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
        #endregion

        #region LoadTwitterFollowers
        private static void LoadTwitterFollowers()
        {
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.InsertTwitterFollowers(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
        }
        #endregion

        #region LoadFacebookFans
        private static void LoadFacebookFans()
        {
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.InsertFacebookFans(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
        }
        #endregion

        #region LoadLinkedInFollowers
        private static void LoadLinkedInFollowers()
        {
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.InsertLinkedInFollowers(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
        #endregion

        #region LoadVideos
        private static void LoadVideos()
        {
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);
            //data.InsertVideos(context);
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
        #endregion

        #region LoadWhitePaperCaseStudyBytes
        private static void LoadWhitePaperCaseStudyBytes()
        {
            //var data = new FakeData();
            ////var context = new FakeCloudCompareContext();
            ////var context = new CloudCompareContext();
            ////string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            //var context = new TMDContext();
            ////data.LoadFakeReferenceData(context);

            //bool retVal = true;
            //while (retVal == true)
            //{
            //    retVal = data.InsertWhitePaperCaseStudyBytes(context);
            //}
            //try
            //{
            //    context.SaveChanges();
            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.Entries)
            //    {
            //        //foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
            //        }
            //    }
            //}

        }
        #endregion

        #region CheckFacebookName
        //private static long CheckFacebookName(string name)
        //{
        //    var data = new FakeData();
        //    //var context = new FakeCloudCompareContext();
        //    //var context = new CloudCompareContext();
        //    //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
        //    var context = new TMDContext();
        //    //data.LoadFakeReferenceData(context);
        //    long retVal = data.CheckFacebookFan(name);
        //    return retVal;
        //}
        #endregion

        #region GetThumbnail
        private static void GetThumbnail(string fileName)
        {
            //var document = ShellObject.FromParsingName(fileName);
        }
        #endregion
    }
}
