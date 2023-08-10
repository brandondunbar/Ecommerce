# IO.Swagger.Api.ProductsApi

All URIs are relative to *http://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiProductsBatchUpdatePut**](ProductsApi.md#apiproductsbatchupdateput) | **PUT** /api/products/batch-update | Bulk update products
[**ApiProductsCategoriesGet**](ProductsApi.md#apiproductscategoriesget) | **GET** /api/products/categories | Retrieve all product categories
[**ApiProductsCategoriesPost**](ProductsApi.md#apiproductscategoriespost) | **POST** /api/products/categories | Create a new product category
[**ApiProductsGet**](ProductsApi.md#apiproductsget) | **GET** /api/products | List all products
[**ApiProductsPost**](ProductsApi.md#apiproductspost) | **POST** /api/products | Add a new product
[**ApiProductsProductIdGet**](ProductsApi.md#apiproductsproductidget) | **GET** /api/products/{productId} | Retrieve details of a specific product
[**ApiProductsProductIdImagesDelete**](ProductsApi.md#apiproductsproductidimagesdelete) | **DELETE** /api/products/{productId}/images | Delete a specific image for a product
[**ApiProductsProductIdImagesGet**](ProductsApi.md#apiproductsproductidimagesget) | **GET** /api/products/{productId}/images | Retrieve images for a specific product
[**ApiProductsProductIdImagesPost**](ProductsApi.md#apiproductsproductidimagespost) | **POST** /api/products/{productId}/images | Upload a new image for a specific product
[**ApiProductsProductIdInventoryGet**](ProductsApi.md#apiproductsproductidinventoryget) | **GET** /api/products/{productId}/inventory | Retrieve inventory data for a specific product
[**ApiProductsProductIdInventoryPut**](ProductsApi.md#apiproductsproductidinventoryput) | **PUT** /api/products/{productId}/inventory | Update inventory data for a specific product
[**ApiProductsProductIdPriceHistoryGet**](ProductsApi.md#apiproductsproductidpricehistoryget) | **GET** /api/products/{productId}/price-history | Retrieve price history for a specific product
[**ApiProductsProductIdPromotionsGet**](ProductsApi.md#apiproductsproductidpromotionsget) | **GET** /api/products/{productId}/promotions | Retrieve promotions for a specific product
[**ApiProductsProductIdRelatedGet**](ProductsApi.md#apiproductsproductidrelatedget) | **GET** /api/products/{productId}/related | Retrieve products related to a specific product
[**ApiProductsProductIdReviewsGet**](ProductsApi.md#apiproductsproductidreviewsget) | **GET** /api/products/{productId}/reviews | Retrieve reviews for a specific product
[**ApiProductsProductIdReviewsPost**](ProductsApi.md#apiproductsproductidreviewspost) | **POST** /api/products/{productId}/reviews | Add a review for a specific product
[**ApiProductsRecommendationsGet**](ProductsApi.md#apiproductsrecommendationsget) | **GET** /api/products/recommendations | Retrieve product recommendations for the user
[**ApiProductsSearchGet**](ProductsApi.md#apiproductssearchget) | **GET** /api/products/search | Search for products
[**ApiProductsTagsGet**](ProductsApi.md#apiproductstagsget) | **GET** /api/products/tags | List all product tags
[**ApiProductsTagsPost**](ProductsApi.md#apiproductstagspost) | **POST** /api/products/tags | Add new product tags
[**ApiProductsTopRatedGet**](ProductsApi.md#apiproductstopratedget) | **GET** /api/products/top-rated | Retrieve top-rated products

<a name="apiproductsbatchupdateput"></a>
# **ApiProductsBatchUpdatePut**
> void ApiProductsBatchUpdatePut (List<ProductUpdate> body)

Bulk update products

Allows for bulk updates to multiple products at once.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsBatchUpdatePutExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new List<ProductUpdate>(); // List<ProductUpdate> | A list of products with updated data.

            try
            {
                // Bulk update products
                apiInstance.ApiProductsBatchUpdatePut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsBatchUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;ProductUpdate&gt;**](ProductUpdate.md)| A list of products with updated data. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductscategoriesget"></a>
# **ApiProductsCategoriesGet**
> List<Category> ApiProductsCategoriesGet ()

Retrieve all product categories

Provides a list of all product categories available.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsCategoriesGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();

            try
            {
                // Retrieve all product categories
                List&lt;Category&gt; result = apiInstance.ApiProductsCategoriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsCategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Category>**](Category.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductscategoriespost"></a>
# **ApiProductsCategoriesPost**
> void ApiProductsCategoriesPost (CategoryInput body)

Create a new product category

Allows administrators to add a new product category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsCategoriesPostExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new CategoryInput(); // CategoryInput | Category details

            try
            {
                // Create a new product category
                apiInstance.ApiProductsCategoriesPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsCategoriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoryInput**](CategoryInput.md)| Category details | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsget"></a>
# **ApiProductsGet**
> List<Product> ApiProductsGet (int? page = null, int? limit = null, string sort = null)

List all products

Returns a list of all products. Supports pagination, filtering, and sorting.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var page = 56;  // int? | Page number for pagination. (optional) 
            var limit = 56;  // int? | Number of products per page for pagination. (optional) 
            var sort = sort_example;  // string | Sorting criteria (e.g., \"price_asc\", \"name_desc\"). (optional) 

            try
            {
                // List all products
                List&lt;Product&gt; result = apiInstance.ApiProductsGet(page, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number for pagination. | [optional] 
 **limit** | **int?**| Number of products per page for pagination. | [optional] 
 **sort** | **string**| Sorting criteria (e.g., \&quot;price_asc\&quot;, \&quot;name_desc\&quot;). | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductspost"></a>
# **ApiProductsPost**
> Product ApiProductsPost (Product body)

Add a new product

Creates a new product based on the provided data and returns the details of the newly added product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsPostExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new Product(); // Product | Product data

            try
            {
                // Add a new product
                Product result = apiInstance.ApiProductsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Product**](Product.md)| Product data | 

### Return type

[**Product**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidget"></a>
# **ApiProductsProductIdGet**
> Product ApiProductsProductIdGet (int? productId)

Retrieve details of a specific product

Returns the detailed information of a product identified by the provided product ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve

            try
            {
                // Retrieve details of a specific product
                Product result = apiInstance.ApiProductsProductIdGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve | 

### Return type

[**Product**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidimagesdelete"></a>
# **ApiProductsProductIdImagesDelete**
> void ApiProductsProductIdImagesDelete (int? productId, string imageId)

Delete a specific image for a product

Allows administrators or authorized users to delete an image associated with the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdImagesDeleteExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to delete an image for.
            var imageId = imageId_example;  // string | ID or identifier of the image to be deleted.

            try
            {
                // Delete a specific image for a product
                apiInstance.ApiProductsProductIdImagesDelete(productId, imageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdImagesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to delete an image for. | 
 **imageId** | **string**| ID or identifier of the image to be deleted. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidimagesget"></a>
# **ApiProductsProductIdImagesGet**
> List<ProductImage> ApiProductsProductIdImagesGet (int? productId)

Retrieve images for a specific product

Provides a list of image URLs or metadata associated with the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdImagesGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve images for.

            try
            {
                // Retrieve images for a specific product
                List&lt;ProductImage&gt; result = apiInstance.ApiProductsProductIdImagesGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdImagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve images for. | 

### Return type

[**List<ProductImage>**](ProductImage.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidimagespost"></a>
# **ApiProductsProductIdImagesPost**
> void ApiProductsProductIdImagesPost (Object body, int? productId)

Upload a new image for a specific product

Allows administrators or authorized users to upload a new image for the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdImagesPostExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new Object(); // Object | Image to be uploaded
            var productId = 56;  // int? | ID of the product to upload an image for.

            try
            {
                // Upload a new image for a specific product
                apiInstance.ApiProductsProductIdImagesPost(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **Object**| Image to be uploaded | 
 **productId** | **int?**| ID of the product to upload an image for. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: image/_*
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidinventoryget"></a>
# **ApiProductsProductIdInventoryGet**
> ProductInventory ApiProductsProductIdInventoryGet (int? productId)

Retrieve inventory data for a specific product

Provides current stock levels and inventory status for the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdInventoryGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve inventory data for.

            try
            {
                // Retrieve inventory data for a specific product
                ProductInventory result = apiInstance.ApiProductsProductIdInventoryGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdInventoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve inventory data for. | 

### Return type

[**ProductInventory**](ProductInventory.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidinventoryput"></a>
# **ApiProductsProductIdInventoryPut**
> void ApiProductsProductIdInventoryPut (ProductInventoryUpdate body, int? productId)

Update inventory data for a specific product

Allows administrators or authorized users to update stock levels and inventory status for the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdInventoryPutExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new ProductInventoryUpdate(); // ProductInventoryUpdate | Updated inventory data
            var productId = 56;  // int? | ID of the product to update inventory data for.

            try
            {
                // Update inventory data for a specific product
                apiInstance.ApiProductsProductIdInventoryPut(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdInventoryPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductInventoryUpdate**](ProductInventoryUpdate.md)| Updated inventory data | 
 **productId** | **int?**| ID of the product to update inventory data for. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidpricehistoryget"></a>
# **ApiProductsProductIdPriceHistoryGet**
> List<ProductPriceHistoryItem> ApiProductsProductIdPriceHistoryGet (int? productId)

Retrieve price history for a specific product

Provides a chronological list of price changes for the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdPriceHistoryGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve price history for.

            try
            {
                // Retrieve price history for a specific product
                List&lt;ProductPriceHistoryItem&gt; result = apiInstance.ApiProductsProductIdPriceHistoryGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdPriceHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve price history for. | 

### Return type

[**List<ProductPriceHistoryItem>**](ProductPriceHistoryItem.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidpromotionsget"></a>
# **ApiProductsProductIdPromotionsGet**
> List<ProductPromotion> ApiProductsProductIdPromotionsGet (int? productId)

Retrieve promotions for a specific product

Provides a list of active and past promotions associated with the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdPromotionsGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve promotions for.

            try
            {
                // Retrieve promotions for a specific product
                List&lt;ProductPromotion&gt; result = apiInstance.ApiProductsProductIdPromotionsGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdPromotionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve promotions for. | 

### Return type

[**List<ProductPromotion>**](ProductPromotion.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidrelatedget"></a>
# **ApiProductsProductIdRelatedGet**
> List<Product> ApiProductsProductIdRelatedGet (int? productId, int? limit = null)

Retrieve products related to a specific product

Provides a list of products that are related to the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdRelatedGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve related products for.
            var limit = 56;  // int? | Limit the number of related products returned (default is 5). (optional)  (default to 5)

            try
            {
                // Retrieve products related to a specific product
                List&lt;Product&gt; result = apiInstance.ApiProductsProductIdRelatedGet(productId, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdRelatedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve related products for. | 
 **limit** | **int?**| Limit the number of related products returned (default is 5). | [optional] [default to 5]

### Return type

[**List<Product>**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidreviewsget"></a>
# **ApiProductsProductIdReviewsGet**
> List<Review> ApiProductsProductIdReviewsGet (int? productId)

Retrieve reviews for a specific product

Provides a list of reviews for the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdReviewsGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | ID of the product to retrieve reviews for.

            try
            {
                // Retrieve reviews for a specific product
                List&lt;Review&gt; result = apiInstance.ApiProductsProductIdReviewsGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdReviewsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| ID of the product to retrieve reviews for. | 

### Return type

[**List<Review>**](Review.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsproductidreviewspost"></a>
# **ApiProductsProductIdReviewsPost**
> void ApiProductsProductIdReviewsPost (ReviewInput body, int? productId)

Add a review for a specific product

Allows authenticated users to submit a review for the given product.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsProductIdReviewsPostExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new ReviewInput(); // ReviewInput | Review details
            var productId = 56;  // int? | ID of the product to review.

            try
            {
                // Add a review for a specific product
                apiInstance.ApiProductsProductIdReviewsPost(body, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsProductIdReviewsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReviewInput**](ReviewInput.md)| Review details | 
 **productId** | **int?**| ID of the product to review. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductsrecommendationsget"></a>
# **ApiProductsRecommendationsGet**
> List<Product> ApiProductsRecommendationsGet (int? limit = null)

Retrieve product recommendations for the user

Provides a list of recommended products based on user behavior, popular products, or other algorithms.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsRecommendationsGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var limit = 56;  // int? | Limit the number of recommended products returned (default is 10). (optional)  (default to 10)

            try
            {
                // Retrieve product recommendations for the user
                List&lt;Product&gt; result = apiInstance.ApiProductsRecommendationsGet(limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsRecommendationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limit the number of recommended products returned (default is 10). | [optional] [default to 10]

### Return type

[**List<Product>**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductssearchget"></a>
# **ApiProductsSearchGet**
> List<Product> ApiProductsSearchGet (string keyword = null, int? categoryId = null, float? minPrice = null, float? maxPrice = null, string sortBy = null, string sortOrder = null)

Search for products

Allows users to search for products based on keywords, categories, price range, and other criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsSearchGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var keyword = keyword_example;  // string | Search term or keyword. (optional) 
            var categoryId = 56;  // int? | ID of the product category to filter by. (optional) 
            var minPrice = 3.4;  // float? | Minimum price for filtering. (optional) 
            var maxPrice = 3.4;  // float? | Maximum price for filtering. (optional) 
            var sortBy = sortBy_example;  // string | Sort the results by date, price, or rating. (optional) 
            var sortOrder = sortOrder_example;  // string | Order of sorting (ascending or descending). (optional) 

            try
            {
                // Search for products
                List&lt;Product&gt; result = apiInstance.ApiProductsSearchGet(keyword, categoryId, minPrice, maxPrice, sortBy, sortOrder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsSearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyword** | **string**| Search term or keyword. | [optional] 
 **categoryId** | **int?**| ID of the product category to filter by. | [optional] 
 **minPrice** | **float?**| Minimum price for filtering. | [optional] 
 **maxPrice** | **float?**| Maximum price for filtering. | [optional] 
 **sortBy** | **string**| Sort the results by date, price, or rating. | [optional] 
 **sortOrder** | **string**| Order of sorting (ascending or descending). | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductstagsget"></a>
# **ApiProductsTagsGet**
> List<string> ApiProductsTagsGet ()

List all product tags

Provides a list of all tags associated with products.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsTagsGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();

            try
            {
                // List all product tags
                List&lt;string&gt; result = apiInstance.ApiProductsTagsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductstagspost"></a>
# **ApiProductsTagsPost**
> void ApiProductsTagsPost (List<string> body)

Add new product tags

Allows administrators or authorized users to add new tags for products.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsTagsPostExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var body = new List<string>(); // List<string> | A list of tags to be added.

            try
            {
                // Add new product tags
                apiInstance.ApiProductsTagsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsTagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;string&gt;**](string.md)| A list of tags to be added. | 

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproductstopratedget"></a>
# **ApiProductsTopRatedGet**
> List<Product> ApiProductsTopRatedGet (int? limit = null, int? minReviewsCount = null)

Retrieve top-rated products

Provides a list of products with the highest average ratings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProductsTopRatedGetExample
    {
        public void main()
        {

            var apiInstance = new ProductsApi();
            var limit = 56;  // int? | Limit the number of top-rated products returned (default is 10). (optional)  (default to 10)
            var minReviewsCount = 56;  // int? | Minimum number of reviews a product should have to be considered in top-rated (optional filter). (optional) 

            try
            {
                // Retrieve top-rated products
                List&lt;Product&gt; result = apiInstance.ApiProductsTopRatedGet(limit, minReviewsCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ApiProductsTopRatedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limit the number of top-rated products returned (default is 10). | [optional] [default to 10]
 **minReviewsCount** | **int?**| Minimum number of reviews a product should have to be considered in top-rated (optional filter). | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
