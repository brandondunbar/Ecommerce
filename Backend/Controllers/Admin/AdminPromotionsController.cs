/*
* AdminPromotionsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminPromotionsController class handles the creation, 
*     retrieval, update, and deletion of promotions on the E-Commerce platform. Promotions can be discounts, offers, 
*     or any other incentives provided to customers, applicable to certain products.
* 
* Classes:
*     AdminPromotionsController:
*         Methods:
*             - ListActivePromotions(): Retrieves all active promotions.
*             - CreateNewPromotion(PromotionData promotionData): Creates a new promotion.
*             - BulkUpdatePromotions(List<PromotionUpdateData> promotionsUpdates): Updates multiple promotions at once.
*             - DeletePromotion(int promotionId): Deletes a specific promotion by ID.
* 
*     PromotionData:
*         Represents a promotion's data structure, encapsulating all necessary details for creating or detailing a promotion.
*         Properties:
*             - promotionId: Unique identifier for the promotion.
*             - name: Name or title of the promotion.
*             - type: Type of promotion (e.g., "Discount", "Buy One Get One Free").
*             - value: The value of the promotion, e.g., discount percentage.
*             - startDate: Start date of the promotion.
*             - endDate: End date of the promotion.
*             - applicableProducts: List of product IDs to which the promotion applies.
*             - notes: Additional notes about the promotion.
*             - createdDate: Date the promotion was created.
*             - modifiedDate: Last modification date for the promotion.
* 
*     PromotionUpdateData:
*         Represents the data structure for updating promotions.
* 
* Dependencies:
*     - PromotionService: Manages CRUD operations for promotions by interacting with the database.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while managing promotions.
* 
* Note:
*     Promotions are crucial for attracting customers and increasing sales. Therefore, careful handling and validation 
*     of promotion data are vital to ensure that promotions are correctly applied and customers are not inconvenienced.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminPromotionsController : ControllerBase
    {
        DECLARE PromotionService promotionService
        DECLARE LoggerService logger

        CONSTRUCTOR(PromotionService pService, LoggerService logService)
        {
            INIT promotionService with pService
            INIT logger with logService
        }

        // GET /api/admin/promotions
        FUNCTION ListActivePromotions() RETURNS IActionResult
        {
            TRY
            {
                List<Promotion> promotions = CALL promotionService.ListActivePromotions()

                RETURN Ok with promotions
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving promotions: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/admin/promotions
        FUNCTION CreateNewPromotion(PromotionData promotionData) RETURNS IActionResult
        {
            TRY
            {
                CALL promotionService.CreateNewPromotion(promotionData)

                RETURN StatusCode 201 with message "Promotion created successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while creating new promotion: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/promotions
        FUNCTION BulkUpdatePromotions(List<PromotionUpdateData> promotionsUpdates) RETURNS IActionResult
        {
            TRY
            {
                CALL promotionService.BulkUpdatePromotions(promotionsUpdates)

                RETURN Ok with message "Promotions updated successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating promotions: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // DELETE /api/admin/promotions
        FUNCTION DeletePromotion(int promotionId) RETURNS IActionResult
        {
            TRY
            {
                CALL promotionService.DeletePromotion(promotionId)

                RETURN Ok with message "Promotion deleted successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while deleting promotion: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class PromotionData
    {
        DECLARE int promotionId
        DECLARE string name
        DECLARE string type
        DECLARE float value
        DECLARE DateTime startDate
        DECLARE DateTime endDate
        DECLARE List<int> applicableProducts
        DECLARE string notes
        DECLARE DateTime createdDate
        DECLARE DateTime modifiedDate
    }

    DEFINE class PromotionUpdateData
    {
        DECLARE int promotionId
        DECLARE string? name
        DECLARE string? type
        DECLARE float? value
        DECLARE DateTime? startDate
        DECLARE DateTime? endDate
        DECLARE List<int>? applicableProducts
        DECLARE string? notes
    }
}
