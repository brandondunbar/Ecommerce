/*
* ProductSearchController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller manages the product search functionality 
*     on the E-Commerce platform. It allows users to search for products based on various criteria such as keywords, 
*     category, price range, and sorting options.
* 
* Classes:
*     ProductSearchController:
*         Methods:
*             - SearchProducts(string? keyword, int? categoryId, float? minPrice, float? maxPrice, string? sortBy, string? sortOrder): 
*               Enables users to search for products based on various criteria. Validates input parameters, logs warnings for invalid inputs, 
*               and fetches the products that match the search criteria.
* 
*     Product:
*         Represents a product in the application.
*         Properties:
*             - Name: The name of the product.
*             - Description: A brief description of the product.
*             - Price: The price of the product.
* 
* Dependencies:
*     - ProductService: Manages product retrieval based on search criteria and interacts with the database.
*     - LoggerService: Logs activities, warnings, and errors.
* 
* Note:
*     Modifications to this class should ensure that the search functionality remains accurate and efficient. 
*     Also, ensure that input validation is strictly maintained to prevent potential issues and security vulnerabilities.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductSearchController : ControllerBase
    {
        DECLARE ProductService productService
        DECLARE LoggerService logger

        CONSTRUCTOR(ProductService pService, LoggerService logService)
        {
            INIT productService with pService
            INIT logger with logService
        }

        // GET /api/products/search
        FUNCTION SearchProducts(string? keyword, int? categoryId, float? minPrice, float? maxPrice, string? sortBy, string? sortOrder) RETURNS IActionResult
        {
            // Validate the input parameters
            IF (minPrice IS NOT NULL AND maxPrice IS NOT NULL AND minPrice > maxPrice)
                LOG warning "Invalid price range in search"
                RETURN BadRequest with message "Invalid price range"
            END IF
            
            IF (sortBy IS NOT NULL AND (sortBy IS NOT "date" AND sortBy IS NOT "price" AND sortBy IS NOT "rating"))
                LOG warning "Invalid sortBy parameter"
                RETURN BadRequest with message "Invalid sortBy value"
            END IF
            
            IF (sortOrder IS NOT NULL AND (sortOrder IS NOT "asc" AND sortOrder IS NOT "desc"))
                LOG warning "Invalid sortOrder parameter"
                RETURN BadRequest with message "Invalid sortOrder value"
            END IF

            TRY
            {
                List<Product> searchResults = CALL productService.SearchProducts(keyword, categoryId, minPrice, maxPrice, sortBy, sortOrder)

                IF searchResults is empty
                    RETURN Ok with message "No products found for the given criteria."
                END IF

                RETURN Ok with searchResults
            }
            CATCH any exception as error
            {
                LOG error "Error while searching for products: {error details}"
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
