/*
* ProductRelatedController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is dedicated to fetching products 
*     related to a specific product on the E-Commerce platform. The determination of related products 
*     is based on attributes like category, tags, or previous user behaviors, like viewing or purchasing patterns.
* 
* Classes:
*     ProductRelatedController:
*         Methods:
*             - GetRelatedProducts(int productId, int? limit = 5): Returns a list of products that are related 
*               to the specified product. The number of related products can be limited using the `limit` parameter.
* 
*     Product:
*         Represents the structure of a product in the platform.
*         Properties:
*             - Name: The name or title of the product.
*             - Description: Detailed information about the product.
*             - Price: Price of the product.
* 
* Dependencies:
*     - ProductService: Responsible for fetching the product details and their related products.
*     - LoggerService: Captures logging events, warnings, and errors.
* 
* Note:
*     Displaying related products is a strategy to enhance user engagement and potentially increase sales. 
*     Ensuring the relevance of these related products is crucial for maintaining a positive user experience. 
*     It's vital to be vigilant about the accuracy and relevance of the products being shown as related.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductRelatedController : ControllerBase
    {
        DECLARE ProductService productService
        DECLARE LoggerService logger

        CONSTRUCTOR(ProductService pService, LoggerService logService)
        {
            INIT productService with pService
            INIT logger with logService
        }

        // GET /api/products/{productId}/related
        FUNCTION GetRelatedProducts(int productId, int? limit = 5) RETURNS IActionResult
        {
            TRY
            {
                Product mainProduct = CALL productService.GetProductById(productId)

                IF mainProduct is null
                    RETURN NotFound with message "Product not found"
                END IF

                List<Product> relatedProducts = CALL productService.GetRelatedProducts(mainProduct, limit)

                RETURN Ok with relatedProducts
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving related products: {error details}"
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
