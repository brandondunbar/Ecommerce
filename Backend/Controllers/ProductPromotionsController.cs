/*
* ProductPromotionsController.cs
*
* Description:
*     Situated in the ECommerceApp.Controllers namespace, this controller is designed for the management 
*     of promotions associated with specific products on the E-Commerce platform. It helps users to 
*     discover current and past promotions linked to a product.
* 
* Classes:
*     ProductPromotionsController:
*         Methods:
*             - GetPromotions(int productId): Retrieves a list of active and past promotions 
*               associated with the given product. If the product doesn't have any promotions 
*               or doesn't exist, it returns a "Product not found" message.
* 
*     PromotionData:
*         Represents the promotion data associated with a product.
*         Properties:
*             - PromotionId: Unique identifier for the promotion.
*             - Name: The name or title of the promotion.
*             - Description: Detailed information about the promotion.
*             - DiscountType: Type of discount (e.g., "percentage" or "fixed_amount").
*             - DiscountValue: Value of the discount based on the DiscountType.
*             - StartDate: Date and time when the promotion started.
*             - EndDate: Date and time when the promotion ended or is scheduled to end.
*             - IsActive: Flag indicating whether the promotion is currently active.
* 
* Dependencies:
*     - PromotionService: Provides methods to retrieve promotion data associated with products.
*     - LoggerService: Captures logging events, warnings, and errors.
* 
* Note:
*     Promotions play a vital role in attracting customers and increasing sales. Keeping a clear record 
*     of promotions helps in analyzing their impact on sales and making informed decisions in future campaigns.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductPromotionsController : ControllerBase
    {
        DECLARE PromotionService promotionService
        DECLARE LoggerService logger

        CONSTRUCTOR(PromotionService pService, LoggerService logService)
        {
            INIT promotionService with pService
            INIT logger with logService
        }

        // GET /api/products/{productId}/promotions
        FUNCTION GetPromotions(int productId) RETURNS IActionResult
        {
            TRY
            {
                PromotionData[] promotions = CALL promotionService.GetPromotionsByProductId(productId)

                IF promotions is null or empty
                    RETURN NotFound with message "Product not found"
                END IF

                RETURN Ok with promotions
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving promotions data: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class PromotionData
    {
        DECLARE string PromotionId
        DECLARE string Name
        DECLARE string Description
        DECLARE string DiscountType
        DECLARE float DiscountValue
        DECLARE DateTime StartDate
        DECLARE DateTime EndDate
        DECLARE bool IsActive
    }
}
