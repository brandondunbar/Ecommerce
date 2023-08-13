/*
* ProductBatchController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is responsible for batch operations related to products, 
*     such as bulk updates and tag management in the E-Commerce platform. It provides endpoints for batch updating products,
*     fetching product tags, and adding new product tags.
* 
* Classes:
*     ProductBatchController:
*         Methods:
*             - BulkUpdateProducts(List<ProductUpdateData> productsToUpdate): Performs batch updates on multiple products. 
*               Validates and updates product details as per the provided data.
*             - GetProductTags(): Fetches a list of all tags associated with products.
*             - AddProductTags(List<string> tagsToAdd): Allows adding a list of new tags associated with products.
* 
*     ProductUpdateData:
*         Represents the data structure for batch updates of products. 
*         Properties:
*             - ProductId: The unique ID of the product to be updated.
*             - Name: The (optional) updated name of the product.
*             - Price: The (optional) updated price of the product.
*             - Inventory: The (optional) updated inventory count of the product.
*             - Description: The (optional) updated description of the product.
* 
* Dependencies:
*     - ProductService: Manages product-related operations, including batch updates and tag management.
*     - LoggerService: Logs activities, warnings, and errors.
* 
* Note:
*     Any modifications to this class should ensure data integrity, especially when dealing with batch updates. 
*     Every product data change should be validated to prevent potential data inconsistencies.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductBatchController : ControllerBase
    {
        DECLARE ProductService productService
        DECLARE LoggerService logger

        CONSTRUCTOR(ProductService pService, LoggerService logService)
        {
            INIT productService with pService
            INIT logger with logService
        }

        // PUT /api/products/batch-update
        FUNCTION BulkUpdateProducts(List<ProductUpdateData> productsToUpdate) RETURNS IActionResult
        {
            TRY
            {
                CALL productService.BatchUpdate(productsToUpdate)
                RETURN Ok with message "Products updated successfully."
            }
            CATCH any exception as error
            {
                LOG error "Error during batch update: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // GET /api/products/tags
        FUNCTION GetProductTags() RETURNS IActionResult
        {
            TRY
            {
                List<string> tags = CALL productService.GetProductTags()
                RETURN Ok with tags
            }
            CATCH any exception as error
            {
                LOG error "Error retrieving product tags: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/products/tags
        FUNCTION AddProductTags(List<string> tagsToAdd) RETURNS IActionResult
        {
            TRY
            {
                CALL productService.AddTags(tagsToAdd)
                RETURN StatusCode 201 with message "Tags added successfully."
            }
            CATCH any exception as error
            {
                LOG error "Error adding product tags: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class ProductUpdateData
    {
        DECLARE int ProductId
        DECLARE string Name, OPTIONAL
        DECLARE float Price, OPTIONAL
        DECLARE int Inventory, OPTIONAL
        DECLARE string Description, OPTIONAL
    }
}
