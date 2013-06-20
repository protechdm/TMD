using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.Domain.Contracts.Repositories;
using TMD.POCOQueryRepository;
using TMD.Domain.Models;
//using GhostscriptSharp;
using System.Drawing;
using System.IO;
using TMD.SocialNetworking;
using TMD.POCOQueryRepository.DataPump;

//using Moq;
//using NUnit.Framework;

namespace TMD.POCOQueryRepository
{
    public class FakeData
    {
        private ITMDContext testContextInstance;

        bool retVal;
        //string MULTIPLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\output%d.jpg";

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public ITMDContext FakeContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region LoadFakeReferenceData
        //[TestMethod]
        public void LoadFakeReferenceData(ITMDContext context)
        {
            //set the context to a fake stub
            //this.FakeContext = new FakeCloudCompareContext();
            this.FakeContext = context;

            //_context = new StationEntities();

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            ////add our sample fake station entities to the repository
            //CloudApplicationDocument td;
            //AdvertisingImage ai;
            //Tag t;
            //ContentText ct;

            retVal = ReferenceData.PumpStatuses(repository);
            this.FakeContext.SaveChanges();

            //retVal = ReferenceData.PumpLevel1ReferenceData(repository);
            ////retVal = ReferenceData.TestLaptop(repository);

            //this.FakeContext.SaveChanges();

            //retVal = ReferenceData.PumpLevel2ReferenceData(repository);


            ////// Mock the Products Repository using Moq
            ////Mock<ICloudCompareContext> mockCloudCompareRepository = new Mock<ICloudCompareContext>();

            ////// Try finding a product by id
            ////CloudApplication testCloudApplication = mockCloudCompareRepository.Object.FindById(2);

            ////Assert.IsNotNull(testCloudApplication); // Test if null
            ////Assert.IsInstanceOfType(typeof(CloudApplication),testCloudApplication); // Test type
            ////Assert.AreEqual("TITLE", testCloudApplication.Title); // Verify it is the right product
        }
        #endregion

        #region LoadFakeProductionData
        public void LoadFakeProductionData(ITMDContext context)
        {

            ////now use this fake stub as the repository
            //var repository = new QueryRepository(this.FakeContext);

            ////retVal = ApplicationProductionData.PumpApplicationData(repository);

            //retVal = CustomerManagementProductionData.PumpCustomerManagementData(repository); //DONE
            //retVal = EmailProductionData.PumpEmailData(repository); //DONE
            //retVal = FinancialProductionData.PumpFinancialData(repository); //DONE
            //retVal = OfficeProductionData.PumpOfficeData(repository); //DONE
            //retVal = PhoneProductionData.PumpPhoneData(repository); //DONE
            //retVal = ProjectManagementProductionData.PumpProjectManagementData(repository); //DONE
            //retVal = StorageAndBackupProductionData.PumpStorageAndBackupData(repository); //DONE
            //retVal = WebConferencingProductionData.PumpWebConferencingData(repository); //DONE
            //retVal = SecurityProductionData.PumpSecurityData(repository); //DONE

            //retVal = AdvertisingImageData.PumpAdvertisingImageData(repository);
            //retVal = TagData.PumpTagData(repository);
            ////retVal = ContentTextData.PumpContentTextData(repository);
            //retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            //retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region LoadFakeContentTextData
        public void LoadFakeContentTextData(ITMDContext context)
        {
            //this.FakeContext = context;
            ////now use this fake stub as the repository
            //var repository = new QueryRepository(this.FakeContext);

            ////retVal = ApplicationProductionData.PumpApplicationData(repository);

            //retVal = ContentTextData.PumpContentTextData(repository);
            ////retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            ////retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region SetLiveStatuses
        public bool SetLiveStatuses(ITMDContext context)
        {
            bool retVal = true;
            //var repository = new QueryRepository(context);

            //foreach (CloudApplication ca in context.CloudApplications.ToList())
            //{
            //    ca.Devices.ForEach(x => x.DeviceStatus = repository.FindStatusByName("LIVE"));
            //    ca.OperatingSystems.ForEach(x => x.OperatingSystemStatus = repository.FindStatusByName("LIVE"));
            //    ca.Browsers.ForEach(x => x.BrowserStatus = repository.FindStatusByName("LIVE"));
            //    ca.Languages.ForEach(x => x.LanguageStatus = repository.FindStatusByName("LIVE"));
            //    ca.SupportTypes.ForEach(x => x.SupportTypeStatus = repository.FindStatusByName("LIVE"));
            //    ca.SupportTerritories.ForEach(x => x.SupportTerritoryStatus = repository.FindStatusByName("LIVE"));
            //    ca.CloudApplicationFeatures.ForEach(x => x.CloudApplicationFeatureStatus = repository.FindStatusByName("LIVE"));
            //    ca.PaymentOptions.ForEach(x => x.PaymentOptionStatus = repository.FindStatusByName("LIVE"));
            //    ca.CloudApplicationApplications.ForEach(x => x.CloudApplicationApplicationStatus = repository.FindStatusByName("LIVE"));
            //}
            return retVal;
        }
        #endregion

        #region InsertRatings
        public void InsertRatings(ITMDContext context, Random r)
        {
            //foreach (CloudApplication ca in context.CloudApplications.ToList())
            //{

            //    ca.AverageOverallRating = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //    ca.AverageEaseOfUse = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //    ca.AverageValueForMoney = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //    ca.AverageFunctionality = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;

            //    foreach (CloudApplicationUserReview car in ca.CloudApplicationUserReviews.ToList())
            //    {
            //        //car.CloudApplicationUserReviewOverallRating = (decimal)r.NextDouble() * 100;
            //        //car.CloudApplicationUserReviewEaseOfUse = (decimal)r.NextDouble() * 100;
            //        //car.CloudApplicationUserReviewValueForMoney = (decimal)r.NextDouble() * 100;
            //        //car.CloudApplicationUserReviewFunctionality = (decimal)r.NextDouble() * 100;
            //        car.CloudApplicationUserReviewOverallRating = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //        car.CloudApplicationUserReviewEaseOfUse = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //        car.CloudApplicationUserReviewValueForMoney = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //        car.CloudApplicationUserReviewFunctionality = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
            //    }
            //}
        }
        #endregion

        #region InsertApplicationWeightings
        public void InsertApplicationWeightings(ITMDContext context, Random r)
        {
            //foreach (CloudApplication ca in context.CloudApplications)
            //{
            //    ca.SearchResultWeighting = (decimal)r.NextDouble() * 100;
            //}
        }
        #endregion

        #region GetImageAsBytes
        public static byte[] GetImageAsBytes(string outputPath)
        {
            //string outputPath = MPU_FILEPATH + MPU_FILE1;
            //System.Drawing.Image i = System.Drawing.Image.FromFile(outputPath);
            //FileStream fs = new FileStream(outputPath, FileMode.Open,FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] image = br.ReadBytes((int)fs.Length);
            byte[] image2 = File.ReadAllBytes(outputPath);
            return image2;
        }
        #endregion

        #region InsertTwitterFollowers
        public void InsertTwitterFollowers(ITMDContext context)
        {
            //Twitter twitter = new Twitter();
            //long followers;
            //var cloudVendors = context.CloudApplications.Select(x => new { VendorName = x.Vendor.VendorName, TwitterFollowers = x.TwitterFollowers }).Distinct().ToList();
            ////foreach (CloudApplication ca in context.CloudApplications.ToList())
            //for (int i = 0; i < cloudVendors.Count; i++)
            //{
            //    //if (ca.TwitterFollowers == 0)
            //    if (cloudVendors[i].TwitterFollowers == 0)
            //    {
            //        followers = twitter.GetTwitterFollowerCount(cloudVendors[i].VendorName);

            //        if (followers > 0)
            //        {
            //            foreach (CloudApplication ca in context.CloudApplications.ToList())
            //            {
            //                if (ca.Vendor.VendorName == cloudVendors[i].VendorName)
            //                {
            //                    ca.TwitterFollowers = followers;
            //                    ca.LastTwitterPing = DateTime.Now;
            //                }
            //            }
            //        }
            //    }
            //}
        }
        #endregion

        #region InsertFacebookFans
        public void InsertFacebookFans(ITMDContext context)
        {
            //Facebook facebook = new Facebook();
            //long fans;
            //var cloudVendors = context.CloudApplications.Select(x => new { VendorName = x.Vendor.VendorName, FacebookFollowers = x.FacebookFollowers }).Distinct().ToList();
            ////foreach (CloudApplication ca in context.CloudApplications.ToList())
            //for (int i = 0; i < cloudVendors.Count; i++)
            //{
            //    //if (ca.FacebookFollowers == 0)
            //    if (cloudVendors[i].FacebookFollowers == 0)
            //    {
            //        fans = facebook.GetFacebookFans(cloudVendors[i].VendorName);
            //        if (fans > 0)
            //        {
            //            foreach (CloudApplication ca in context.CloudApplications.ToList())
            //            {
            //                ca.FacebookFollowers = fans;
            //                ca.LastFacebookPing = DateTime.Now;
            //            }
            //        }
            //    }
            //}
        }
        #endregion

        #region CheckFacebookFan
        public long CheckFacebookFan(string name)
        {
            Facebook facebook = new Facebook();
            long fans;
            fans = facebook.GetFacebookFans(name);
            return fans;
        }
        #endregion

        #region InsertLinkedInFollowers
        public void InsertLinkedInFollowers(ITMDContext context)
        {

            ////set the context to a fake stub
            ////this.FakeContext = new FakeCloudCompareContext();
            //this.FakeContext = context;

            ////_context = new StationEntities();

            ////now use this fake stub as the repository
            ////var repository = new QueryRepository(this.FakeContext);


            //LinkedIn linkedIn = new LinkedIn();
            //long followers;
            //foreach (CloudApplication ca in context.CloudApplications.ToList())
            //{
            //    if (ca.LinkedInFollowers == 0)
            //    {
            //        followers = linkedIn.GetLinkedInFollowerCount(ca.Vendor.VendorName);
            //        ca.LinkedInFollowers = followers;
            //        ca.LastLinkedInPing = DateTime.Now;
            //    }
            //}
        }
        #endregion

        #region InsertVideos
        public void InsertVideos(ITMDContext context)
        {
            //this.FakeContext = context;
            //var repository = new QueryRepository(context);

            //foreach (CloudApplication ca in context.CloudApplications.ToList())
            //{
            //    ca.CloudApplicationVideos = new List<CloudApplicationVideo>()
            //    {
            //        new CloudApplicationVideo()
            //        {
            //            CloudApplicationVideoFileFormat = "mp4",
            //            CloudApplicationVideoFileName = "pr6.mp4",
            //            CloudApplicationVideoURL = null,
            //            //IsLive = true,
            //            CloudApplicationVideoStatus = repository.FindStatusByName("LIVE"),
            //            IsLocalDomain = true,
            //            IsYouTubeStream = false,
            //        },
            //        //new CloudApplicationVideo()
            //        //{
            //        //    CloudApplicationVideoFileFormat = "ogv",
            //        //    CloudApplicationVideoFileName = "pr6.ogv",
            //        //    CloudApplicationVideoURL = null,
            //        //    IsLive = true,
            //        //    IsLocalDomain = true,
            //        //    IsYouTubeStream = false,
            //        //},
            //        //new CloudApplicationVideo()
            //        //{
            //        //    CloudApplicationVideoFileFormat = "webm",
            //        //    CloudApplicationVideoFileName = "pr6.webm",
            //        //    CloudApplicationVideoURL = null,
            //        //    IsLive = true,
            //        //    IsLocalDomain = true,
            //        //    IsYouTubeStream = false,
            //        //},
            //        //new CloudApplicationVideo()
            //        //{
            //        //    CloudApplicationVideoFileFormat = null,
            //        //    CloudApplicationVideoFileName = null,
            //        //    CloudApplicationVideoURL = "http://www.youtube.com/v/MrMNHwmd9Hc",
            //        //    IsLive = true,
            //        //    IsLocalDomain = true,
            //        //    IsYouTubeStream = true,
            //        //},
            //        //new CloudApplicationVideo()
            //        //{
            //        //    CloudApplicationVideoFileFormat = "swf",
            //        //    CloudApplicationVideoFileName = "win_98b.swf",
            //        //    CloudApplicationVideoURL = null,
            //        //    IsLive = true,
            //        //    IsLocalDomain = true,
            //        //    IsYouTubeStream = false,
            //        //},
            //        //new CloudApplicationVideo()
            //        //{
            //        //    CloudApplicationVideoFileFormat = "mov",
            //        //    CloudApplicationVideoFileName = "sample_iTunes.mov",
            //        //    CloudApplicationVideoURL = null,
            //        //    IsLive = true,
            //        //    IsLocalDomain = true,
            //        //    IsYouTubeStream = false,
            //        //},
            //    };
            //}
        }
        #endregion

        #region InsertWhitePaperCaseStudyBytes
        public bool InsertWhitePaperCaseStudyBytes(ITMDContext context)
        {
            this.FakeContext = context;
            bool inserted = false;
            //var repository = new QueryRepository(this.FakeContext);

            ////foreach (ThumbnailDocument td in context.ThumbnailDocuments.ToList())
            //CloudApplicationDocument sampleTD = context.CloudApplicationDocuments.Where(x => x.CloudApplicationDocumentImage == null).FirstOrDefault();
            //if (sampleTD != null)
            //{
            //    string fileName = sampleTD.CloudApplicationDocumentPhysicalFilePath + sampleTD.CloudApplicationDocumentFileName;
            //    byte[] documentToInsert = File.ReadAllBytes(fileName);


            //    var TDs = context.CloudApplicationDocuments
            //        .Where(x => (x.CloudApplicationDocumentPhysicalFilePath + x.CloudApplicationDocumentFileName) == fileName)
            //        .Where(x => x.CloudApplicationDocumentImage == null)
            //        .ToList();

            //    foreach (CloudApplicationDocument td in TDs)
            //    {
            //        if (td.CloudApplicationDocumentImage == null)
            //        {
            //            CloudApplicationDocumentImage tdd = new CloudApplicationDocumentImage();
            //            //tdd.ThumbnailDocumentBytes = File.ReadAllBytes(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName);
            //            tdd.CloudApplicationDocumentBytes = documentToInsert;
            //            tdd.CloudApplicationDocumentImageStatus = repository.FindStatusByName("LIVE");
            //            td.CloudApplicationDocumentImage = tdd;
            //            td.CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE");
            //            //context.SaveChanges();
            //            inserted = true;
            //        }
            //    }
            //    context.SaveChanges();
            //}
            return inserted;
        }
        #endregion

        #region GetPublisherName
        public static string GetPublisherName(int publisherID)
        {
            string REVIEW_PUBLISHER_NAME_1 = "Computer Weekly";
            string REVIEW_PUBLISHER_NAME_2 = "silicon.com";
            switch (publisherID)
            {
                case 1:
                    return REVIEW_PUBLISHER_NAME_1;
                case 2:
                    return REVIEW_PUBLISHER_NAME_2;
                default:
                    return "";
            }
        }
        #endregion

        #region GetPublisherHeadline
        public static string GetPublisherHeadline()
        {
            string REVIEW_HEADLINE = "Great example of SaaS for the growing business";
            return REVIEW_HEADLINE;
        }
        #endregion
    }
}
