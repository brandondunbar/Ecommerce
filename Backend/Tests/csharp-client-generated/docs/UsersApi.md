# IO.Swagger.Api.UsersApi

All URIs are relative to *http://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUsersForgotPasswordPost**](UsersApi.md#apiusersforgotpasswordpost) | **POST** /api/users/forgot-password | Request password reset
[**ApiUsersLoginPost**](UsersApi.md#apiusersloginpost) | **POST** /api/users/login | Authenticate a user
[**ApiUsersNotificationsGet**](UsersApi.md#apiusersnotificationsget) | **GET** /api/users/notifications | Retrieve user&#x27;s notifications
[**ApiUsersNotificationsPut**](UsersApi.md#apiusersnotificationsput) | **PUT** /api/users/notifications | Mark notifications as read
[**ApiUsersOrdersGet**](UsersApi.md#apiusersordersget) | **GET** /api/users/orders | Retrieve user&#x27;s order history
[**ApiUsersProfileDelete**](UsersApi.md#apiusersprofiledelete) | **DELETE** /api/users/profile | Delete user&#x27;s account
[**ApiUsersProfileGet**](UsersApi.md#apiusersprofileget) | **GET** /api/users/profile | Retrieve the authenticated user&#x27;s profile
[**ApiUsersProfilePasswordPut**](UsersApi.md#apiusersprofilepasswordput) | **PUT** /api/users/profile/password | Change the user&#x27;s password
[**ApiUsersProfilePut**](UsersApi.md#apiusersprofileput) | **PUT** /api/users/profile | Update the authenticated user&#x27;s profile
[**ApiUsersRegisterPost**](UsersApi.md#apiusersregisterpost) | **POST** /api/users/register | Register a new user
[**ApiUsersResetPasswordPost**](UsersApi.md#apiusersresetpasswordpost) | **POST** /api/users/reset-password | Reset user password
[**ApiUsersReviewsGet**](UsersApi.md#apiusersreviewsget) | **GET** /api/users/reviews | Retrieve user&#x27;s product reviews
[**ApiUsersReviewsPost**](UsersApi.md#apiusersreviewspost) | **POST** /api/users/reviews | Create a new product review
[**ApiUsersWishlistsGet**](UsersApi.md#apiuserswishlistsget) | **GET** /api/users/wishlists | Retrieve user&#x27;s wishlists
[**ApiUsersWishlistsPost**](UsersApi.md#apiuserswishlistspost) | **POST** /api/users/wishlists | Create a new wishlist

<a name="apiusersforgotpasswordpost"></a>
# **ApiUsersForgotPasswordPost**
> void ApiUsersForgotPasswordPost (UsersForgotpasswordBody body)

Request password reset

Allows a user to request a password reset link or code, which will be sent to their registered email.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersForgotPasswordPostExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new UsersForgotpasswordBody(); // UsersForgotpasswordBody | Email address associated with the user's account

            try
            {
                // Request password reset
                apiInstance.ApiUsersForgotPasswordPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersForgotPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersForgotpasswordBody**](UsersForgotpasswordBody.md)| Email address associated with the user&#x27;s account | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersloginpost"></a>
# **ApiUsersLoginPost**
> InlineResponse200 ApiUsersLoginPost (UserLogin body)

Authenticate a user

Authenticate a user using their username (or email) and password.  If successful, a JWT token will be returned for subsequent authenticated requests.  Note: There's a rate limit of 5 requests per minute to prevent brute force attacks. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersLoginPostExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new UserLogin(); // UserLogin | User login credentials

            try
            {
                // Authenticate a user
                InlineResponse200 result = apiInstance.ApiUsersLoginPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersLoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserLogin**](UserLogin.md)| User login credentials | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersnotificationsget"></a>
# **ApiUsersNotificationsGet**
> List<Notification> ApiUsersNotificationsGet (string status = null)

Retrieve user's notifications

Allows the authenticated user to view a list of their notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersNotificationsGetExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var status = status_example;  // string | Filter notifications by status. (optional) 

            try
            {
                // Retrieve user's notifications
                List&lt;Notification&gt; result = apiInstance.ApiUsersNotificationsGet(status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersNotificationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Filter notifications by status. | [optional] 

### Return type

[**List<Notification>**](Notification.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersnotificationsput"></a>
# **ApiUsersNotificationsPut**
> void ApiUsersNotificationsPut (UsersNotificationsBody body)

Mark notifications as read

Allows the authenticated user to mark specific notifications or all notifications as read.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersNotificationsPutExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new UsersNotificationsBody(); // UsersNotificationsBody | IDs of notifications to mark as read or a command to mark all as read.

            try
            {
                // Mark notifications as read
                apiInstance.ApiUsersNotificationsPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersNotificationsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersNotificationsBody**](UsersNotificationsBody.md)| IDs of notifications to mark as read or a command to mark all as read. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersordersget"></a>
# **ApiUsersOrdersGet**
> List<Order> ApiUsersOrdersGet (int? page = null, int? limit = null, string status = null)

Retrieve user's order history

Allows the authenticated user to view a list of their past orders.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersOrdersGetExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var page = 56;  // int? | Page number for pagination. (optional) 
            var limit = 56;  // int? | Number of orders per page for pagination. (optional) 
            var status = status_example;  // string | Filter orders by status (e.g., \"completed\", \"pending\", \"canceled\"). (optional) 

            try
            {
                // Retrieve user's order history
                List&lt;Order&gt; result = apiInstance.ApiUsersOrdersGet(page, limit, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number for pagination. | [optional] 
 **limit** | **int?**| Number of orders per page for pagination. | [optional] 
 **status** | **string**| Filter orders by status (e.g., \&quot;completed\&quot;, \&quot;pending\&quot;, \&quot;canceled\&quot;). | [optional] 

### Return type

[**List<Order>**](Order.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersprofiledelete"></a>
# **ApiUsersProfileDelete**
> void ApiUsersProfileDelete ()

Delete user's account

Allows the authenticated user to permanently delete their account. This action should be used with caution as it might be irreversible.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersProfileDeleteExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();

            try
            {
                // Delete user's account
                apiInstance.ApiUsersProfileDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersProfileDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersprofileget"></a>
# **ApiUsersProfileGet**
> UserProfile ApiUsersProfileGet ()

Retrieve the authenticated user's profile

Returns the profile details of the currently authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersProfileGetExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();

            try
            {
                // Retrieve the authenticated user's profile
                UserProfile result = apiInstance.ApiUsersProfileGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersProfileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersprofilepasswordput"></a>
# **ApiUsersProfilePasswordPut**
> void ApiUsersProfilePasswordPut (ProfilePasswordBody body)

Change the user's password

Allows the authenticated user to change their password.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersProfilePasswordPutExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new ProfilePasswordBody(); // ProfilePasswordBody | Current and new password details

            try
            {
                // Change the user's password
                apiInstance.ApiUsersProfilePasswordPut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersProfilePasswordPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProfilePasswordBody**](ProfilePasswordBody.md)| Current and new password details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersprofileput"></a>
# **ApiUsersProfilePut**
> UserProfile ApiUsersProfilePut (UserProfile body)

Update the authenticated user's profile

Updates the profile details of the currently authenticated user based on the provided data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersProfilePutExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new UserProfile(); // UserProfile | Updated user profile data

            try
            {
                // Update the authenticated user's profile
                UserProfile result = apiInstance.ApiUsersProfilePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersProfilePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserProfile**](UserProfile.md)| Updated user profile data | 

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersregisterpost"></a>
# **ApiUsersRegisterPost**
> UserProfile ApiUsersRegisterPost (UserRegistration body)

Register a new user

Register a new user with the provided details. Once registered, the user can authenticate using the /api/authorize endpoint. <br>Note - Passwords must be at least 8 characters long, contain at least 1 number and 1 special character.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersRegisterPostExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new UserRegistration(); // UserRegistration | User data needed for registration

            try
            {
                // Register a new user
                UserProfile result = apiInstance.ApiUsersRegisterPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersRegisterPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRegistration**](UserRegistration.md)| User data needed for registration | 

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersresetpasswordpost"></a>
# **ApiUsersResetPasswordPost**
> void ApiUsersResetPasswordPost (UsersResetpasswordBody body)

Reset user password

Allows a user to reset their password using a valid reset token or code received in their email.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersResetPasswordPostExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new UsersResetpasswordBody(); // UsersResetpasswordBody | Password reset token and new password details

            try
            {
                // Reset user password
                apiInstance.ApiUsersResetPasswordPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersResetPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersResetpasswordBody**](UsersResetpasswordBody.md)| Password reset token and new password details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersreviewsget"></a>
# **ApiUsersReviewsGet**
> List<Review> ApiUsersReviewsGet ()

Retrieve user's product reviews

Allows the authenticated user to view a list of their product reviews.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersReviewsGetExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();

            try
            {
                // Retrieve user's product reviews
                List&lt;Review&gt; result = apiInstance.ApiUsersReviewsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersReviewsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Review>**](Review.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiusersreviewspost"></a>
# **ApiUsersReviewsPost**
> void ApiUsersReviewsPost (ReviewInput body)

Create a new product review

Allows the authenticated user to submit a review for a product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersReviewsPostExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new ReviewInput(); // ReviewInput | Review details

            try
            {
                // Create a new product review
                apiInstance.ApiUsersReviewsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersReviewsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReviewInput**](ReviewInput.md)| Review details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiuserswishlistsget"></a>
# **ApiUsersWishlistsGet**
> List<Wishlist> ApiUsersWishlistsGet ()

Retrieve user's wishlists

Allows the authenticated user to view a list of their wishlists.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersWishlistsGetExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();

            try
            {
                // Retrieve user's wishlists
                List&lt;Wishlist&gt; result = apiInstance.ApiUsersWishlistsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersWishlistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Wishlist>**](Wishlist.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiuserswishlistspost"></a>
# **ApiUsersWishlistsPost**
> void ApiUsersWishlistsPost (Wishlist body)

Create a new wishlist

Allows the authenticated user to create a new wishlist.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersWishlistsPostExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var body = new Wishlist(); // Wishlist | Wishlist details

            try
            {
                // Create a new wishlist
                apiInstance.ApiUsersWishlistsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersWishlistsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Wishlist**](Wishlist.md)| Wishlist details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
