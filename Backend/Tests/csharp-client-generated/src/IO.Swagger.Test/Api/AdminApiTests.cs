/* 
 * E-commerce API
 *
 * API for E-commerce Platform
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon.dunbar97@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AdminApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AdminApiTests
    {
        private AdminApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AdminApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdminApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AdminApi
            //Assert.IsInstanceOfType(typeof(AdminApi), instance, "instance is a AdminApi");
        }

        /// <summary>
        /// Test ApiAdminAffiliatesGet
        /// </summary>
        [Test]
        public void ApiAdminAffiliatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminAffiliatesGet();
            //Assert.IsInstanceOf<List<Affiliate>> (response, "response is List<Affiliate>");
        }
        /// <summary>
        /// Test ApiAdminAffiliatesPost
        /// </summary>
        [Test]
        public void ApiAdminAffiliatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AffiliateCreate body = null;
            //instance.ApiAdminAffiliatesPost(body);
            
        }
        /// <summary>
        /// Test ApiAdminContentBannersGet
        /// </summary>
        [Test]
        public void ApiAdminContentBannersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminContentBannersGet();
            //Assert.IsInstanceOf<List<Banner>> (response, "response is List<Banner>");
        }
        /// <summary>
        /// Test ApiAdminContentBannersPost
        /// </summary>
        [Test]
        public void ApiAdminContentBannersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BannerCreate body = null;
            //instance.ApiAdminContentBannersPost(body);
            
        }
        /// <summary>
        /// Test ApiAdminContentPagesGet
        /// </summary>
        [Test]
        public void ApiAdminContentPagesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminContentPagesGet();
            //Assert.IsInstanceOf<List<ContentPage>> (response, "response is List<ContentPage>");
        }
        /// <summary>
        /// Test ApiAdminFeedbackGet
        /// </summary>
        [Test]
        public void ApiAdminFeedbackGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string status = null;
            //string type = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.ApiAdminFeedbackGet(status, type, page, limit);
            //Assert.IsInstanceOf<List<Feedback>> (response, "response is List<Feedback>");
        }
        /// <summary>
        /// Test ApiAdminFeedbackPut
        /// </summary>
        [Test]
        public void ApiAdminFeedbackPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FeedbackUpdate body = null;
            //instance.ApiAdminFeedbackPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminInventoryGet
        /// </summary>
        [Test]
        public void ApiAdminInventoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? belowThreshold = null;
            //var response = instance.ApiAdminInventoryGet(belowThreshold);
            //Assert.IsInstanceOf<List<InventoryItem>> (response, "response is List<InventoryItem>");
        }
        /// <summary>
        /// Test ApiAdminInventoryPut
        /// </summary>
        [Test]
        public void ApiAdminInventoryPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<InventoryUpdate> body = null;
            //instance.ApiAdminInventoryPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminLogsGet
        /// </summary>
        [Test]
        public void ApiAdminLogsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string logLevel = null;
            //string _event = null;
            //var response = instance.ApiAdminLogsGet(startDate, endDate, logLevel, _event);
            //Assert.IsInstanceOf<List<SystemLog>> (response, "response is List<SystemLog>");
        }
        /// <summary>
        /// Test ApiAdminMonitoringGet
        /// </summary>
        [Test]
        public void ApiAdminMonitoringGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //string metric = null;
            //var response = instance.ApiAdminMonitoringGet(startTime, endTime, metric);
            //Assert.IsInstanceOf<List<MonitoringMetric>> (response, "response is List<MonitoringMetric>");
        }
        /// <summary>
        /// Test ApiAdminNotificationsPost
        /// </summary>
        [Test]
        public void ApiAdminNotificationsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdminNotificationsBody body = null;
            //instance.ApiAdminNotificationsPost(body);
            
        }
        /// <summary>
        /// Test ApiAdminOrdersGet
        /// </summary>
        [Test]
        public void ApiAdminOrdersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string status = null;
            //DateTime? fromDate = null;
            //DateTime? toDate = null;
            //var response = instance.ApiAdminOrdersGet(status, fromDate, toDate);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        /// <summary>
        /// Test ApiAdminOrdersPut
        /// </summary>
        [Test]
        public void ApiAdminOrdersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<OrderUpdate> body = null;
            //instance.ApiAdminOrdersPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminPartnershipsGet
        /// </summary>
        [Test]
        public void ApiAdminPartnershipsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminPartnershipsGet();
            //Assert.IsInstanceOf<List<Partnership>> (response, "response is List<Partnership>");
        }
        /// <summary>
        /// Test ApiAdminPartnershipsPost
        /// </summary>
        [Test]
        public void ApiAdminPartnershipsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PartnershipCreate body = null;
            //instance.ApiAdminPartnershipsPost(body);
            
        }
        /// <summary>
        /// Test ApiAdminPromotionsDelete
        /// </summary>
        [Test]
        public void ApiAdminPromotionsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? promotionId = null;
            //instance.ApiAdminPromotionsDelete(promotionId);
            
        }
        /// <summary>
        /// Test ApiAdminPromotionsGet
        /// </summary>
        [Test]
        public void ApiAdminPromotionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminPromotionsGet();
            //Assert.IsInstanceOf<List<Promotion>> (response, "response is List<Promotion>");
        }
        /// <summary>
        /// Test ApiAdminPromotionsPost
        /// </summary>
        [Test]
        public void ApiAdminPromotionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Promotion body = null;
            //instance.ApiAdminPromotionsPost(body);
            
        }
        /// <summary>
        /// Test ApiAdminPromotionsPut
        /// </summary>
        [Test]
        public void ApiAdminPromotionsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<PromotionUpdate> body = null;
            //instance.ApiAdminPromotionsPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminReportsSalesGet
        /// </summary>
        [Test]
        public void ApiAdminReportsSalesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string granularity = null;
            //var response = instance.ApiAdminReportsSalesGet(startDate, endDate, granularity);
            //Assert.IsInstanceOf<SalesReport> (response, "response is SalesReport");
        }
        /// <summary>
        /// Test ApiAdminReportsUserActivityGet
        /// </summary>
        [Test]
        public void ApiAdminReportsUserActivityGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string granularity = null;
            //var response = instance.ApiAdminReportsUserActivityGet(startDate, endDate, granularity);
            //Assert.IsInstanceOf<UserActivityReport> (response, "response is UserActivityReport");
        }
        /// <summary>
        /// Test ApiAdminReviewsDelete
        /// </summary>
        [Test]
        public void ApiAdminReviewsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? reviewId = null;
            //instance.ApiAdminReviewsDelete(reviewId);
            
        }
        /// <summary>
        /// Test ApiAdminReviewsGet
        /// </summary>
        [Test]
        public void ApiAdminReviewsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? productId = null;
            //long? userId = null;
            //string status = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.ApiAdminReviewsGet(productId, userId, status, page, limit);
            //Assert.IsInstanceOf<List<Review>> (response, "response is List<Review>");
        }
        /// <summary>
        /// Test ApiAdminReviewsPut
        /// </summary>
        [Test]
        public void ApiAdminReviewsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReviewUpdate body = null;
            //instance.ApiAdminReviewsPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminSettingsGet
        /// </summary>
        [Test]
        public void ApiAdminSettingsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminSettingsGet();
            //Assert.IsInstanceOf<PlatformSettings> (response, "response is PlatformSettings");
        }
        /// <summary>
        /// Test ApiAdminSettingsPut
        /// </summary>
        [Test]
        public void ApiAdminSettingsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlatformSettingsUpdate body = null;
            //instance.ApiAdminSettingsPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminUsersDelete
        /// </summary>
        [Test]
        public void ApiAdminUsersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> body = null;
            //instance.ApiAdminUsersDelete(body);
            
        }
        /// <summary>
        /// Test ApiAdminUsersGet
        /// </summary>
        [Test]
        public void ApiAdminUsersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiAdminUsersGet();
            //Assert.IsInstanceOf<List<User>> (response, "response is List<User>");
        }
        /// <summary>
        /// Test ApiAdminUsersPost
        /// </summary>
        [Test]
        public void ApiAdminUsersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserRegistration body = null;
            //instance.ApiAdminUsersPost(body);
            
        }
        /// <summary>
        /// Test ApiAdminUsersPut
        /// </summary>
        [Test]
        public void ApiAdminUsersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<UserUpdate> body = null;
            //instance.ApiAdminUsersPut(body);
            
        }
        /// <summary>
        /// Test ApiAdminUsersUserIdBansDelete
        /// </summary>
        [Test]
        public void ApiAdminUsersUserIdBansDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //instance.ApiAdminUsersUserIdBansDelete(userId);
            
        }
        /// <summary>
        /// Test ApiAdminUsersUserIdBansPost
        /// </summary>
        [Test]
        public void ApiAdminUsersUserIdBansPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserIdBansBody body = null;
            //int? userId = null;
            //instance.ApiAdminUsersUserIdBansPost(body, userId);
            
        }
        /// <summary>
        /// Test ApiAdminUsersUserIdRolesDelete
        /// </summary>
        [Test]
        public void ApiAdminUsersUserIdRolesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //int? userId = null;
            //instance.ApiAdminUsersUserIdRolesDelete(body, userId);
            
        }
        /// <summary>
        /// Test ApiAdminUsersUserIdRolesGet
        /// </summary>
        [Test]
        public void ApiAdminUsersUserIdRolesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.ApiAdminUsersUserIdRolesGet(userId);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        /// <summary>
        /// Test ApiAdminUsersUserIdRolesPut
        /// </summary>
        [Test]
        public void ApiAdminUsersUserIdRolesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //int? userId = null;
            //instance.ApiAdminUsersUserIdRolesPut(body, userId);
            
        }
    }

}