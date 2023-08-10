# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *http://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticateUser**](AuthenticationApi.md#authenticateuser) | **POST** /api/authorize | Authenticate a user and return a JWT token

<a name="authenticateuser"></a>
# **AuthenticateUser**
> InlineResponse200 AuthenticateUser (ApiAuthorizeBody body)

Authenticate a user and return a JWT token

Authenticate with a username and password to receive a JWT token.  This token should be included in the Authorization header for subsequent requests to protected endpoints. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthenticateUserExample
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();
            var body = new ApiAuthorizeBody(); // ApiAuthorizeBody | 

            try
            {
                // Authenticate a user and return a JWT token
                InlineResponse200 result = apiInstance.AuthenticateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiAuthorizeBody**](ApiAuthorizeBody.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
