/*
* ProductPriceHistoryController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is dedicated to managing operations 
*     associated with the price history of products on the E-Commerce platform. This provides insight into 
*     the historical changes in the price of a product over time.
* 
* Classes:
*     ProductPriceHistoryController:
*         Methods:
*             - GetPriceHistory(int productId): Retrieves the chronological list of price changes for a specific product. 
*               If the product doesn't exist or has no price history, it returns a "Product not found" message.
* 
*     PriceHistoryData:
*         Represents the price data of a product at a specific point in time. 
*         Properties:
*             - Price: The price of the product at that time.
*             - EffectiveDate: Date and time when this price became effective.
*             - Reason: Optional field indicating the reason for the price change (e.g., "seasonal sale").
* 
* Dependencies:
*     - ProductService: Offers methods for retrieving product price history data.
*     - LoggerService: Handles logging events, warnings, and errors.
* 
* Note:
*     It's important to track price history to analyze market trends and make informed pricing decisions in the future.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductPriceHistoryController : ControllerBase
    {
        DECLARE ProductService productService
        DECLARE LoggerService logger

        CONSTRUCTOR(ProductService pService, LoggerService logService)
        {
            INIT productService with pService
            INIT logger with logService
        }

        // GET /api/products/{productId}/price-history
        FUNCTION GetPriceHistory(int productId) RETURNS IActionResult
        {
            TRY
            {
                PriceHistoryData[] priceHistory = CALL productService.GetPriceHistoryByProductId(productId)

                IF priceHistory is null or empty
                    RETURN NotFound with message "Product not found"
                END IF

                RETURN Ok with priceHistory
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving price history data: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class PriceHistoryData
    {
        DECLARE float Price
        DECLARE DateTime EffectiveDate
        DECLARE string Reason
    }
}
