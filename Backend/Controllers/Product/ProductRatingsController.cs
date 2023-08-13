/*
* ProductRatingsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is responsible for managing product ratings 
*     on the E-Commerce platform. It provides an endpoint to retrieve the top-rated products based on user ratings.
* 
* Classes:
*     ProductRatingsController:
*         Methods:
*             - GetTopRatedProducts(int? limit = 10, int? minReviewsCount = null): Retrieves the top-rated products 
*               based on user ratings. It supports pagination through the `limit` parameter and can filter products 
*               based on a minimum number of reviews through the `minReviewsCount` parameter.
* 
*     Product:
*         Represents the data structure of a product in the platform.
*         Properties:
*             - Name: The name or title of the product.
*             - Description: Detailed information about the product.
*             - Price: Price of the product.
* 
* Dependencies:
*     - RatingService: Provides methods to retrieve top-rated products based on user ratings.
*     - LoggerService: Captures logging events, warnings, and errors.
* 
* Note:
*     Ratings play a significant role in influencing consumer purchase decisions. Accurate representation 
*     of product ratings ensures that users can trust the products they purchase. Ensure that all 
*     methods in this class adhere to the highest standards of accuracy and integrity.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductRatingsController : ControllerBase
    {
        DECLARE RatingService ratingService
        DECLARE LoggerService logger

        CONSTRUCTOR(RatingService rService, LoggerService logService)
        {
            INIT ratingService with rService
            INIT logger with logService
        }

        // GET /api/products/top-rated
        FUNCTION GetTopRatedProducts(int? limit = 10, int? minReviewsCount = null) RETURNS IActionResult
        {
            TRY
            {
                List<Product> topRatedProducts = CALL ratingService.GetTopRatedProducts(limit, minReviewsCount)

                RETURN Ok with topRatedProducts
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving top-rated products: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Product
    {
        DECLARE string Name
        DECLARE string Description
        DECLARE float Price
    }
}
