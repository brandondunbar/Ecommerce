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
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductsApiTests
    {
        private ProductsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductsApi
            //Assert.IsInstanceOfType(typeof(ProductsApi), instance, "instance is a ProductsApi");
        }

        /// <summary>
        /// Test ApiProductsBatchUpdatePut
        /// </summary>
        [Test]
        public void ApiProductsBatchUpdatePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ProductUpdate> body = null;
            //instance.ApiProductsBatchUpdatePut(body);
            
        }
        /// <summary>
        /// Test ApiProductsCategoriesGet
        /// </summary>
        [Test]
        public void ApiProductsCategoriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiProductsCategoriesGet();
            //Assert.IsInstanceOf<List<Category>> (response, "response is List<Category>");
        }
        /// <summary>
        /// Test ApiProductsCategoriesPost
        /// </summary>
        [Test]
        public void ApiProductsCategoriesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CategoryInput body = null;
            //instance.ApiProductsCategoriesPost(body);
            
        }
        /// <summary>
        /// Test ApiProductsGet
        /// </summary>
        [Test]
        public void ApiProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.ApiProductsGet(page, limit, sort);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        /// <summary>
        /// Test ApiProductsPost
        /// </summary>
        [Test]
        public void ApiProductsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Product body = null;
            //var response = instance.ApiProductsPost(body);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        /// <summary>
        /// Test ApiProductsProductIdGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //var response = instance.ApiProductsProductIdGet(productId);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        /// <summary>
        /// Test ApiProductsProductIdImagesDelete
        /// </summary>
        [Test]
        public void ApiProductsProductIdImagesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //string imageId = null;
            //instance.ApiProductsProductIdImagesDelete(productId, imageId);
            
        }
        /// <summary>
        /// Test ApiProductsProductIdImagesGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdImagesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //var response = instance.ApiProductsProductIdImagesGet(productId);
            //Assert.IsInstanceOf<List<ProductImage>> (response, "response is List<ProductImage>");
        }
        /// <summary>
        /// Test ApiProductsProductIdImagesPost
        /// </summary>
        [Test]
        public void ApiProductsProductIdImagesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object body = null;
            //int? productId = null;
            //instance.ApiProductsProductIdImagesPost(body, productId);
            
        }
        /// <summary>
        /// Test ApiProductsProductIdInventoryGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdInventoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //var response = instance.ApiProductsProductIdInventoryGet(productId);
            //Assert.IsInstanceOf<ProductInventory> (response, "response is ProductInventory");
        }
        /// <summary>
        /// Test ApiProductsProductIdInventoryPut
        /// </summary>
        [Test]
        public void ApiProductsProductIdInventoryPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductInventoryUpdate body = null;
            //int? productId = null;
            //instance.ApiProductsProductIdInventoryPut(body, productId);
            
        }
        /// <summary>
        /// Test ApiProductsProductIdPriceHistoryGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdPriceHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //var response = instance.ApiProductsProductIdPriceHistoryGet(productId);
            //Assert.IsInstanceOf<List<ProductPriceHistoryItem>> (response, "response is List<ProductPriceHistoryItem>");
        }
        /// <summary>
        /// Test ApiProductsProductIdPromotionsGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdPromotionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //var response = instance.ApiProductsProductIdPromotionsGet(productId);
            //Assert.IsInstanceOf<List<ProductPromotion>> (response, "response is List<ProductPromotion>");
        }
        /// <summary>
        /// Test ApiProductsProductIdRelatedGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdRelatedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //int? limit = null;
            //var response = instance.ApiProductsProductIdRelatedGet(productId, limit);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        /// <summary>
        /// Test ApiProductsProductIdReviewsGet
        /// </summary>
        [Test]
        public void ApiProductsProductIdReviewsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //var response = instance.ApiProductsProductIdReviewsGet(productId);
            //Assert.IsInstanceOf<List<Review>> (response, "response is List<Review>");
        }
        /// <summary>
        /// Test ApiProductsProductIdReviewsPost
        /// </summary>
        [Test]
        public void ApiProductsProductIdReviewsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReviewInput body = null;
            //int? productId = null;
            //instance.ApiProductsProductIdReviewsPost(body, productId);
            
        }
        /// <summary>
        /// Test ApiProductsRecommendationsGet
        /// </summary>
        [Test]
        public void ApiProductsRecommendationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //var response = instance.ApiProductsRecommendationsGet(limit);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        /// <summary>
        /// Test ApiProductsSearchGet
        /// </summary>
        [Test]
        public void ApiProductsSearchGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyword = null;
            //int? categoryId = null;
            //float? minPrice = null;
            //float? maxPrice = null;
            //string sortBy = null;
            //string sortOrder = null;
            //var response = instance.ApiProductsSearchGet(keyword, categoryId, minPrice, maxPrice, sortBy, sortOrder);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        /// <summary>
        /// Test ApiProductsTagsGet
        /// </summary>
        [Test]
        public void ApiProductsTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiProductsTagsGet();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        /// <summary>
        /// Test ApiProductsTagsPost
        /// </summary>
        [Test]
        public void ApiProductsTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> body = null;
            //instance.ApiProductsTagsPost(body);
            
        }
        /// <summary>
        /// Test ApiProductsTopRatedGet
        /// </summary>
        [Test]
        public void ApiProductsTopRatedGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? minReviewsCount = null;
            //var response = instance.ApiProductsTopRatedGet(limit, minReviewsCount);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
    }

}
