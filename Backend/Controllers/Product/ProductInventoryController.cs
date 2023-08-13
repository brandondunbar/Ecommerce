/*
* ProductInventoryController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is responsible for handling operations 
*     related to product inventory within the E-Commerce platform. It provides endpoints for retrieving the current 
*     inventory data of a specific product and updating the inventory data.
* 
* Classes:
*     ProductInventoryController:
*         Methods:
*             - GetInventory(int productId): Retrieves the current inventory data of a specific product. 
*               If the product doesn't exist, it returns a "Product not found" message.
*             - UpdateInventory(int productId, InventoryData updatedInventory): Updates the inventory data 
*               of a specific product. If the product doesn't exist or the provided inventory data is invalid, 
*               it returns an appropriate error message.
* 
*     InventoryData:
*         Represents the inventory data of a product within the system. 
*         Properties:
*             - StockLevel: Represents the current number of items in stock.
*             - Status: Represents the current inventory status, e.g., "in_stock", "out_of_stock".
*             - LastUpdated: The date and time when the inventory was last updated.
* 
* Dependencies:
*     - ProductService: Provides methods for retrieving and updating product inventory data.
*     - LoggerService: Logs events, warnings, and errors.
* 
* Note:
*     Ensure accurate and timely updates to the inventory data. Consistency between the displayed stock 
*     level and the actual stock is crucial to avoid overselling or underselling.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductInventoryController : ControllerBase
    {
        DECLARE ProductService productService
        DECLARE LoggerService logger

        CONSTRUCTOR(ProductService pService, LoggerService logService)
        {
            INIT productService with pService
            INIT logger with logService
        }

        // GET /api/products/{productId}/inventory
        FUNCTION GetInventory(int productId) RETURNS IActionResult
        {
            TRY
            {
                InventoryData inventory = CALL productService.GetInventoryByProductId(productId)

                IF inventory is null
                    RETURN NotFound with message "Product not found"
                END IF

                RETURN Ok with inventory
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving inventory data: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/products/{productId}/inventory
        FUNCTION UpdateInventory(int productId, InventoryData updatedInventory) RETURNS IActionResult
        {
            TRY
            {
                IF updatedInventory is invalid
                    RETURN BadRequest with message "Invalid request data"
                END IF

                BOOL success = CALL productService.UpdateInventory(productId, updatedInventory)

                IF NOT success
                    RETURN NotFound with message "Product not found"
                END IF

                RETURN Ok with message "Inventory data updated successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating inventory data: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class InventoryData
    {
        DECLARE int StockLevel
        DECLARE string Status
        DECLARE DateTime LastUpdated
    }
}
