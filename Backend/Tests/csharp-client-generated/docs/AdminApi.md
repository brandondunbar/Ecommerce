# IO.Swagger.Api.AdminApi

All URIs are relative to *http://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAdminAffiliatesGet**](AdminApi.md#apiadminaffiliatesget) | **GET** /api/admin/affiliates | Retrieve a list of affiliates
[**ApiAdminAffiliatesPost**](AdminApi.md#apiadminaffiliatespost) | **POST** /api/admin/affiliates | Add a new affiliate
[**ApiAdminContentBannersGet**](AdminApi.md#apiadmincontentbannersget) | **GET** /api/admin/content/banners | Retrieve a list of promotional banners
[**ApiAdminContentBannersPost**](AdminApi.md#apiadmincontentbannerspost) | **POST** /api/admin/content/banners | Create a new promotional banner
[**ApiAdminContentPagesGet**](AdminApi.md#apiadmincontentpagesget) | **GET** /api/admin/content/pages | Retrieve a list of content pages
[**ApiAdminFeedbackGet**](AdminApi.md#apiadminfeedbackget) | **GET** /api/admin/feedback | Retrieve a list of user feedback
[**ApiAdminFeedbackPut**](AdminApi.md#apiadminfeedbackput) | **PUT** /api/admin/feedback | Update feedback details
[**ApiAdminInventoryGet**](AdminApi.md#apiadmininventoryget) | **GET** /api/admin/inventory | List all inventory items
[**ApiAdminInventoryPut**](AdminApi.md#apiadmininventoryput) | **PUT** /api/admin/inventory | Bulk update inventory
[**ApiAdminLogsGet**](AdminApi.md#apiadminlogsget) | **GET** /api/admin/logs | Retrieve system logs
[**ApiAdminMonitoringGet**](AdminApi.md#apiadminmonitoringget) | **GET** /api/admin/monitoring | Retrieve system monitoring data
[**ApiAdminNotificationsPost**](AdminApi.md#apiadminnotificationspost) | **POST** /api/admin/notifications | Send a notification to a user
[**ApiAdminOrdersGet**](AdminApi.md#apiadminordersget) | **GET** /api/admin/orders | List all orders
[**ApiAdminOrdersPut**](AdminApi.md#apiadminordersput) | **PUT** /api/admin/orders | Bulk update orders
[**ApiAdminPartnershipsGet**](AdminApi.md#apiadminpartnershipsget) | **GET** /api/admin/partnerships | Retrieve a list of business partnerships
[**ApiAdminPartnershipsPost**](AdminApi.md#apiadminpartnershipspost) | **POST** /api/admin/partnerships | Add a new business partnership
[**ApiAdminPromotionsDelete**](AdminApi.md#apiadminpromotionsdelete) | **DELETE** /api/admin/promotions | Delete a promotion
[**ApiAdminPromotionsGet**](AdminApi.md#apiadminpromotionsget) | **GET** /api/admin/promotions | List all active promotions
[**ApiAdminPromotionsPost**](AdminApi.md#apiadminpromotionspost) | **POST** /api/admin/promotions | Create a new promotion
[**ApiAdminPromotionsPut**](AdminApi.md#apiadminpromotionsput) | **PUT** /api/admin/promotions | Bulk update promotions
[**ApiAdminReportsSalesGet**](AdminApi.md#apiadminreportssalesget) | **GET** /api/admin/reports/sales | Generate and retrieve a sales report
[**ApiAdminReportsUserActivityGet**](AdminApi.md#apiadminreportsuseractivityget) | **GET** /api/admin/reports/user-activity | Generate and retrieve a user activity report
[**ApiAdminReviewsDelete**](AdminApi.md#apiadminreviewsdelete) | **DELETE** /api/admin/reviews | Delete a specific review
[**ApiAdminReviewsGet**](AdminApi.md#apiadminreviewsget) | **GET** /api/admin/reviews | Retrieve a list of product reviews
[**ApiAdminReviewsPut**](AdminApi.md#apiadminreviewsput) | **PUT** /api/admin/reviews | Update the status of a review
[**ApiAdminSettingsGet**](AdminApi.md#apiadminsettingsget) | **GET** /api/admin/settings | Retrieve platform settings
[**ApiAdminSettingsPut**](AdminApi.md#apiadminsettingsput) | **PUT** /api/admin/settings | Update platform settings
[**ApiAdminUsersDelete**](AdminApi.md#apiadminusersdelete) | **DELETE** /api/admin/users | Bulk delete users
[**ApiAdminUsersGet**](AdminApi.md#apiadminusersget) | **GET** /api/admin/users | List all users
[**ApiAdminUsersPost**](AdminApi.md#apiadminuserspost) | **POST** /api/admin/users | Add a new user
[**ApiAdminUsersPut**](AdminApi.md#apiadminusersput) | **PUT** /api/admin/users | Bulk update users
[**ApiAdminUsersUserIdBansDelete**](AdminApi.md#apiadminusersuseridbansdelete) | **DELETE** /api/admin/users/{userId}/bans | Unban a specific user
[**ApiAdminUsersUserIdBansPost**](AdminApi.md#apiadminusersuseridbanspost) | **POST** /api/admin/users/{userId}/bans | Ban a specific user
[**ApiAdminUsersUserIdRolesDelete**](AdminApi.md#apiadminusersuseridrolesdelete) | **DELETE** /api/admin/users/{userId}/roles | Remove roles from a specific user
[**ApiAdminUsersUserIdRolesGet**](AdminApi.md#apiadminusersuseridrolesget) | **GET** /api/admin/users/{userId}/roles | List roles for a specific user
[**ApiAdminUsersUserIdRolesPut**](AdminApi.md#apiadminusersuseridrolesput) | **PUT** /api/admin/users/{userId}/roles | Assign or update roles for a specific user

<a name="apiadminaffiliatesget"></a>
# **ApiAdminAffiliatesGet**
> List<Affiliate> ApiAdminAffiliatesGet ()

Retrieve a list of affiliates

Fetches a list of all affiliates associated with the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminAffiliatesGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // Retrieve a list of affiliates
                List&lt;Affiliate&gt; result = apiInstance.ApiAdminAffiliatesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminAffiliatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Affiliate>**](Affiliate.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminaffiliatespost"></a>
# **ApiAdminAffiliatesPost**
> void ApiAdminAffiliatesPost (AffiliateCreate body)

Add a new affiliate

Registers a new affiliate partner with the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminAffiliatesPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new AffiliateCreate(); // AffiliateCreate | Data for the new affiliate.

            try
            {
                // Add a new affiliate
                apiInstance.ApiAdminAffiliatesPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminAffiliatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AffiliateCreate**](AffiliateCreate.md)| Data for the new affiliate. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadmincontentbannersget"></a>
# **ApiAdminContentBannersGet**
> List<Banner> ApiAdminContentBannersGet ()

Retrieve a list of promotional banners

Fetches a list of all promotional banners currently on the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminContentBannersGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // Retrieve a list of promotional banners
                List&lt;Banner&gt; result = apiInstance.ApiAdminContentBannersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminContentBannersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Banner>**](Banner.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadmincontentbannerspost"></a>
# **ApiAdminContentBannersPost**
> void ApiAdminContentBannersPost (BannerCreate body)

Create a new promotional banner

Allows administrators to add a new promotional banner.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminContentBannersPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new BannerCreate(); // BannerCreate | Data for the new promotional banner.

            try
            {
                // Create a new promotional banner
                apiInstance.ApiAdminContentBannersPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminContentBannersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BannerCreate**](BannerCreate.md)| Data for the new promotional banner. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadmincontentpagesget"></a>
# **ApiAdminContentPagesGet**
> List<ContentPage> ApiAdminContentPagesGet ()

Retrieve a list of content pages

Fetches a list of all static content pages available on the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminContentPagesGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // Retrieve a list of content pages
                List&lt;ContentPage&gt; result = apiInstance.ApiAdminContentPagesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminContentPagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ContentPage>**](ContentPage.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminfeedbackget"></a>
# **ApiAdminFeedbackGet**
> List<Feedback> ApiAdminFeedbackGet (string status = null, string type = null, int? page = null, int? limit = null)

Retrieve a list of user feedback

Lists all feedback submissions with filtering and pagination capabilities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminFeedbackGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var status = status_example;  // string | Filter feedback by status (e.g., reviewed, pending). (optional) 
            var type = type_example;  // string | Filter feedback by type (e.g., bug, feature request, comment). (optional) 
            var page = 56;  // int? | Pagination - page number. (optional) 
            var limit = 56;  // int? | Pagination - number of feedback items per page. (optional) 

            try
            {
                // Retrieve a list of user feedback
                List&lt;Feedback&gt; result = apiInstance.ApiAdminFeedbackGet(status, type, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminFeedbackGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Filter feedback by status (e.g., reviewed, pending). | [optional] 
 **type** | **string**| Filter feedback by type (e.g., bug, feature request, comment). | [optional] 
 **page** | **int?**| Pagination - page number. | [optional] 
 **limit** | **int?**| Pagination - number of feedback items per page. | [optional] 

### Return type

[**List<Feedback>**](Feedback.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminfeedbackput"></a>
# **ApiAdminFeedbackPut**
> void ApiAdminFeedbackPut (FeedbackUpdate body)

Update feedback details

Allows administrators to update feedback status or add comments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminFeedbackPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new FeedbackUpdate(); // FeedbackUpdate | Feedback update details

            try
            {
                // Update feedback details
                apiInstance.ApiAdminFeedbackPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminFeedbackPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FeedbackUpdate**](FeedbackUpdate.md)| Feedback update details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadmininventoryget"></a>
# **ApiAdminInventoryGet**
> List<InventoryItem> ApiAdminInventoryGet (int? belowThreshold = null)

List all inventory items

Provides a list of all products with their current inventory levels and other related details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminInventoryGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var belowThreshold = 56;  // int? | Filter products that have inventory below a certain threshold. (optional) 

            try
            {
                // List all inventory items
                List&lt;InventoryItem&gt; result = apiInstance.ApiAdminInventoryGet(belowThreshold);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminInventoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **belowThreshold** | **int?**| Filter products that have inventory below a certain threshold. | [optional] 

### Return type

[**List<InventoryItem>**](InventoryItem.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadmininventoryput"></a>
# **ApiAdminInventoryPut**
> void ApiAdminInventoryPut (List<InventoryUpdate> body)

Bulk update inventory

Allows administrators to update inventory levels for multiple products at once.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminInventoryPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<InventoryUpdate>(); // List<InventoryUpdate> | List of inventory updates.

            try
            {
                // Bulk update inventory
                apiInstance.ApiAdminInventoryPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminInventoryPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;InventoryUpdate&gt;**](InventoryUpdate.md)| List of inventory updates. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminlogsget"></a>
# **ApiAdminLogsGet**
> List<SystemLog> ApiAdminLogsGet (DateTime? startDate = null, DateTime? endDate = null, string logLevel = null, string _event = null)

Retrieve system logs

Fetches logs based on filters like date range, log level, or specific events.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminLogsGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var startDate = 2013-10-20;  // DateTime? | Starting date to filter logs. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Ending date to filter logs. (optional) 
            var logLevel = logLevel_example;  // string | Level of log (e.g., INFO, ERROR, WARNING). (optional) 
            var _event = _event_example;  // string | Specific event to filter logs. (optional) 

            try
            {
                // Retrieve system logs
                List&lt;SystemLog&gt; result = apiInstance.ApiAdminLogsGet(startDate, endDate, logLevel, _event);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminLogsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| Starting date to filter logs. | [optional] 
 **endDate** | **DateTime?**| Ending date to filter logs. | [optional] 
 **logLevel** | **string**| Level of log (e.g., INFO, ERROR, WARNING). | [optional] 
 **_event** | **string**| Specific event to filter logs. | [optional] 

### Return type

[**List<SystemLog>**](SystemLog.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminmonitoringget"></a>
# **ApiAdminMonitoringGet**
> List<MonitoringMetric> ApiAdminMonitoringGet (DateTime? startTime = null, DateTime? endTime = null, string metric = null)

Retrieve system monitoring data

Fetches monitoring metrics based on specified filters like time range or specific metrics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminMonitoringGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Starting timestamp to filter monitoring data. (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Ending timestamp to filter monitoring data. (optional) 
            var metric = metric_example;  // string | Specific metric to retrieve (e.g., \"CPU_Usage\", \"Response_Time\"). (optional) 

            try
            {
                // Retrieve system monitoring data
                List&lt;MonitoringMetric&gt; result = apiInstance.ApiAdminMonitoringGet(startTime, endTime, metric);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminMonitoringGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **DateTime?**| Starting timestamp to filter monitoring data. | [optional] 
 **endTime** | **DateTime?**| Ending timestamp to filter monitoring data. | [optional] 
 **metric** | **string**| Specific metric to retrieve (e.g., \&quot;CPU_Usage\&quot;, \&quot;Response_Time\&quot;). | [optional] 

### Return type

[**List<MonitoringMetric>**](MonitoringMetric.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminnotificationspost"></a>
# **ApiAdminNotificationsPost**
> void ApiAdminNotificationsPost (AdminNotificationsBody body)

Send a notification to a user

Allows authorized entities (e.g., administrators or automated systems) to send a notification to a specific user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminNotificationsPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new AdminNotificationsBody(); // AdminNotificationsBody | Notification details and target user

            try
            {
                // Send a notification to a user
                apiInstance.ApiAdminNotificationsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminNotificationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdminNotificationsBody**](AdminNotificationsBody.md)| Notification details and target user | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminordersget"></a>
# **ApiAdminOrdersGet**
> List<Order> ApiAdminOrdersGet (string status = null, DateTime? fromDate = null, DateTime? toDate = null)

List all orders

Provides a list of all orders placed on the platform, with filters for date, status, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminOrdersGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var status = status_example;  // string | Filter orders by their status (e.g., \"pending\", \"shipped\", \"completed\", \"returned\"). (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Filter orders placed after this date. (optional) 
            var toDate = 2013-10-20;  // DateTime? | Filter orders placed before this date. (optional) 

            try
            {
                // List all orders
                List&lt;Order&gt; result = apiInstance.ApiAdminOrdersGet(status, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Filter orders by their status (e.g., \&quot;pending\&quot;, \&quot;shipped\&quot;, \&quot;completed\&quot;, \&quot;returned\&quot;). | [optional] 
 **fromDate** | **DateTime?**| Filter orders placed after this date. | [optional] 
 **toDate** | **DateTime?**| Filter orders placed before this date. | [optional] 

### Return type

[**List<Order>**](Order.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminordersput"></a>
# **ApiAdminOrdersPut**
> void ApiAdminOrdersPut (List<OrderUpdate> body)

Bulk update orders

Allows administrators to update multiple orders at once, typically for changing order status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminOrdersPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<OrderUpdate>(); // List<OrderUpdate> | List of orders with updated data.

            try
            {
                // Bulk update orders
                apiInstance.ApiAdminOrdersPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminOrdersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;OrderUpdate&gt;**](OrderUpdate.md)| List of orders with updated data. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminpartnershipsget"></a>
# **ApiAdminPartnershipsGet**
> List<Partnership> ApiAdminPartnershipsGet ()

Retrieve a list of business partnerships

Fetches a list of all business partnerships associated with the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminPartnershipsGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // Retrieve a list of business partnerships
                List&lt;Partnership&gt; result = apiInstance.ApiAdminPartnershipsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminPartnershipsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Partnership>**](Partnership.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminpartnershipspost"></a>
# **ApiAdminPartnershipsPost**
> void ApiAdminPartnershipsPost (PartnershipCreate body)

Add a new business partnership

Registers a new business partnership or collaboration with the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminPartnershipsPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new PartnershipCreate(); // PartnershipCreate | Data for the new partnership.

            try
            {
                // Add a new business partnership
                apiInstance.ApiAdminPartnershipsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminPartnershipsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PartnershipCreate**](PartnershipCreate.md)| Data for the new partnership. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminpromotionsdelete"></a>
# **ApiAdminPromotionsDelete**
> void ApiAdminPromotionsDelete (int? promotionId)

Delete a promotion

Allows administrators to delete an existing promotion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminPromotionsDeleteExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var promotionId = 56;  // int? | ID of the promotion to delete.

            try
            {
                // Delete a promotion
                apiInstance.ApiAdminPromotionsDelete(promotionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminPromotionsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **promotionId** | **int?**| ID of the promotion to delete. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminpromotionsget"></a>
# **ApiAdminPromotionsGet**
> List<Promotion> ApiAdminPromotionsGet ()

List all active promotions

Provides a list of all active promotions on the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminPromotionsGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // List all active promotions
                List&lt;Promotion&gt; result = apiInstance.ApiAdminPromotionsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminPromotionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Promotion>**](Promotion.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminpromotionspost"></a>
# **ApiAdminPromotionsPost**
> void ApiAdminPromotionsPost (Promotion body)

Create a new promotion

Allows administrators to create a new promotion or discount.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminPromotionsPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new Promotion(); // Promotion | Details of the new promotion.

            try
            {
                // Create a new promotion
                apiInstance.ApiAdminPromotionsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminPromotionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Promotion**](Promotion.md)| Details of the new promotion. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminpromotionsput"></a>
# **ApiAdminPromotionsPut**
> void ApiAdminPromotionsPut (List<PromotionUpdate> body)

Bulk update promotions

Allows administrators to update multiple promotions at once.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminPromotionsPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<PromotionUpdate>(); // List<PromotionUpdate> | List of promotions with updated data.

            try
            {
                // Bulk update promotions
                apiInstance.ApiAdminPromotionsPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminPromotionsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;PromotionUpdate&gt;**](PromotionUpdate.md)| List of promotions with updated data. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminreportssalesget"></a>
# **ApiAdminReportsSalesGet**
> SalesReport ApiAdminReportsSalesGet (DateTime? startDate = null, DateTime? endDate = null, string granularity = null)

Generate and retrieve a sales report

Provides an overview of sales, including total sales, revenue, top-selling products, and other related metrics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminReportsSalesGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var startDate = 2013-10-20;  // DateTime? | Start date for the report period. (optional) 
            var endDate = 2013-10-20;  // DateTime? | End date for the report period. (optional) 
            var granularity = granularity_example;  // string | Level of detail or aggregation for the report, e.g., daily, weekly, monthly. (optional) 

            try
            {
                // Generate and retrieve a sales report
                SalesReport result = apiInstance.ApiAdminReportsSalesGet(startDate, endDate, granularity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminReportsSalesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| Start date for the report period. | [optional] 
 **endDate** | **DateTime?**| End date for the report period. | [optional] 
 **granularity** | **string**| Level of detail or aggregation for the report, e.g., daily, weekly, monthly. | [optional] 

### Return type

[**SalesReport**](SalesReport.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminreportsuseractivityget"></a>
# **ApiAdminReportsUserActivityGet**
> UserActivityReport ApiAdminReportsUserActivityGet (DateTime? startDate = null, DateTime? endDate = null, string granularity = null)

Generate and retrieve a user activity report

Provides insights into user behaviors, including login frequency, pages visited, time spent, and other metrics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminReportsUserActivityGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var startDate = 2013-10-20;  // DateTime? | Start date for the report period. (optional) 
            var endDate = 2013-10-20;  // DateTime? | End date for the report period. (optional) 
            var granularity = granularity_example;  // string | Level of detail or aggregation for the report, e.g., daily, weekly, monthly. (optional) 

            try
            {
                // Generate and retrieve a user activity report
                UserActivityReport result = apiInstance.ApiAdminReportsUserActivityGet(startDate, endDate, granularity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminReportsUserActivityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| Start date for the report period. | [optional] 
 **endDate** | **DateTime?**| End date for the report period. | [optional] 
 **granularity** | **string**| Level of detail or aggregation for the report, e.g., daily, weekly, monthly. | [optional] 

### Return type

[**UserActivityReport**](UserActivityReport.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminreviewsdelete"></a>
# **ApiAdminReviewsDelete**
> void ApiAdminReviewsDelete (long? reviewId)

Delete a specific review

Allows administrators to delete inappropriate or irrelevant reviews.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminReviewsDeleteExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var reviewId = 789;  // long? | ID of the review to be deleted.

            try
            {
                // Delete a specific review
                apiInstance.ApiAdminReviewsDelete(reviewId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminReviewsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reviewId** | **long?**| ID of the review to be deleted. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminreviewsget"></a>
# **ApiAdminReviewsGet**
> List<Review> ApiAdminReviewsGet (long? productId = null, long? userId = null, string status = null, int? page = null, int? limit = null)

Retrieve a list of product reviews

Lists all product reviews with filtering and pagination capabilities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminReviewsGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var productId = 789;  // long? | Filter reviews by specific product ID. (optional) 
            var userId = 789;  // long? | Filter reviews by specific user ID. (optional) 
            var status = status_example;  // string | Filter reviews by status (e.g., approved, pending, rejected). (optional) 
            var page = 56;  // int? | Pagination - page number. (optional) 
            var limit = 56;  // int? | Pagination - number of reviews per page. (optional) 

            try
            {
                // Retrieve a list of product reviews
                List&lt;Review&gt; result = apiInstance.ApiAdminReviewsGet(productId, userId, status, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminReviewsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **long?**| Filter reviews by specific product ID. | [optional] 
 **userId** | **long?**| Filter reviews by specific user ID. | [optional] 
 **status** | **string**| Filter reviews by status (e.g., approved, pending, rejected). | [optional] 
 **page** | **int?**| Pagination - page number. | [optional] 
 **limit** | **int?**| Pagination - number of reviews per page. | [optional] 

### Return type

[**List<Review>**](Review.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminreviewsput"></a>
# **ApiAdminReviewsPut**
> void ApiAdminReviewsPut (ReviewUpdate body)

Update the status of a review

Allows administrators to approve, reject, or update review status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminReviewsPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new ReviewUpdate(); // ReviewUpdate | Review update details

            try
            {
                // Update the status of a review
                apiInstance.ApiAdminReviewsPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminReviewsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReviewUpdate**](ReviewUpdate.md)| Review update details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminsettingsget"></a>
# **ApiAdminSettingsGet**
> PlatformSettings ApiAdminSettingsGet ()

Retrieve platform settings

Fetches the current configuration and settings of the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminSettingsGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // Retrieve platform settings
                PlatformSettings result = apiInstance.ApiAdminSettingsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminSettingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PlatformSettings**](PlatformSettings.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminsettingsput"></a>
# **ApiAdminSettingsPut**
> void ApiAdminSettingsPut (PlatformSettingsUpdate body)

Update platform settings

Allows administrators to modify and configure platform settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminSettingsPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new PlatformSettingsUpdate(); // PlatformSettingsUpdate | Updated platform settings data.

            try
            {
                // Update platform settings
                apiInstance.ApiAdminSettingsPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminSettingsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlatformSettingsUpdate**](PlatformSettingsUpdate.md)| Updated platform settings data. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersdelete"></a>
# **ApiAdminUsersDelete**
> void ApiAdminUsersDelete (List<int?> body)

Bulk delete users

Allows administrators to delete multiple users at once.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersDeleteExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<int?>(); // List<int?> | A list of user IDs to be deleted.

            try
            {
                // Bulk delete users
                apiInstance.ApiAdminUsersDelete(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;int?&gt;**](int?.md)| A list of user IDs to be deleted. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersget"></a>
# **ApiAdminUsersGet**
> List<User> ApiAdminUsersGet ()

List all users

Provides a list of all registered users on the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();

            try
            {
                // List all users
                List&lt;User&gt; result = apiInstance.ApiAdminUsersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<User>**](User.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminuserspost"></a>
# **ApiAdminUsersPost**
> void ApiAdminUsersPost (UserRegistration body)

Add a new user

Allows administrators to manually add a new user to the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new UserRegistration(); // UserRegistration | User data for the new user.

            try
            {
                // Add a new user
                apiInstance.ApiAdminUsersPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRegistration**](UserRegistration.md)| User data for the new user. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersput"></a>
# **ApiAdminUsersPut**
> void ApiAdminUsersPut (List<UserUpdate> body)

Bulk update users

Allows administrators to update multiple users at once.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<UserUpdate>(); // List<UserUpdate> | A list of users with updated data.

            try
            {
                // Bulk update users
                apiInstance.ApiAdminUsersPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;UserUpdate&gt;**](UserUpdate.md)| A list of users with updated data. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersuseridbansdelete"></a>
# **ApiAdminUsersUserIdBansDelete**
> void ApiAdminUsersUserIdBansDelete (int? userId)

Unban a specific user

Allows administrators to lift a ban on a user, restoring their access to the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersUserIdBansDeleteExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var userId = 56;  // int? | ID of the user to unban.

            try
            {
                // Unban a specific user
                apiInstance.ApiAdminUsersUserIdBansDelete(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersUserIdBansDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user to unban. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersuseridbanspost"></a>
# **ApiAdminUsersUserIdBansPost**
> void ApiAdminUsersUserIdBansPost (UserIdBansBody body, int? userId)

Ban a specific user

Allows administrators to ban a user, preventing them from accessing the platform or making transactions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersUserIdBansPostExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new UserIdBansBody(); // UserIdBansBody | Details and reason for the ban.
            var userId = 56;  // int? | ID of the user to ban.

            try
            {
                // Ban a specific user
                apiInstance.ApiAdminUsersUserIdBansPost(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersUserIdBansPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserIdBansBody**](UserIdBansBody.md)| Details and reason for the ban. | 
 **userId** | **int?**| ID of the user to ban. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersuseridrolesdelete"></a>
# **ApiAdminUsersUserIdRolesDelete**
> void ApiAdminUsersUserIdRolesDelete (List<string> body, int? userId)

Remove roles from a specific user

Allows administrators to remove specific roles from a user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersUserIdRolesDeleteExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<string>(); // List<string> | List of roles to be removed from the user.
            var userId = 56;  // int? | ID of the user to remove roles from.

            try
            {
                // Remove roles from a specific user
                apiInstance.ApiAdminUsersUserIdRolesDelete(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersUserIdRolesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| List of roles to be removed from the user. | 
 **userId** | **int?**| ID of the user to remove roles from. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersuseridrolesget"></a>
# **ApiAdminUsersUserIdRolesGet**
> List<string> ApiAdminUsersUserIdRolesGet (int? userId)

List roles for a specific user

Provides a list of roles assigned to the specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersUserIdRolesGetExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var userId = 56;  // int? | ID of the user to retrieve roles for.

            try
            {
                // List roles for a specific user
                List&lt;string&gt; result = apiInstance.ApiAdminUsersUserIdRolesGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersUserIdRolesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**| ID of the user to retrieve roles for. | 

### Return type

**List<string>**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiadminusersuseridrolesput"></a>
# **ApiAdminUsersUserIdRolesPut**
> void ApiAdminUsersUserIdRolesPut (List<string> body, int? userId)

Assign or update roles for a specific user

Allows administrators to assign or modify roles for a given user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAdminUsersUserIdRolesPutExample
    {
        public void main()
        {

            var apiInstance = new AdminApi();
            var body = new List<string>(); // List<string> | List of roles to be assigned to the user.
            var userId = 56;  // int? | ID of the user to assign or update roles.

            try
            {
                // Assign or update roles for a specific user
                apiInstance.ApiAdminUsersUserIdRolesPut(body, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminUsersUserIdRolesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| List of roles to be assigned to the user. | 
 **userId** | **int?**| ID of the user to assign or update roles. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
