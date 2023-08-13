/*
* ProductBatchController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is responsible for managing product-related 
*     operations in the E-Commerce application. It handles product retrieval, creation, and specific product details fetching.
* 
* Classes:
*     ProductsController:
*         Methods:
*             - GetProducts(int? page, int? limit, string? sort): Retrieves a list of products, supporting pagination, 
*               limiting the number of results, and sorting.
*             - CreateProduct(ProductRequest productRequest): Accepts product details and adds a new product 
*               entry to the database.
*             - GetProductById(int productId): Fetches specific product details using its unique productId.
* 
*     ProductRequest:
*         Represents the data structure for creating a new product, capturing product details.
* 
*     Product:
*         Represents a product in the database.
*         Properties:
*             - ProductId: The unique ID for the product.
*             - Name: The name of the product.
*             - Description: A brief description of the product.
*             - Price: The price of the product.
* 
* Dependencies:
*     - ProductService: Manages CRUD operations related to products and interacts with the database.
*     - AuthService: Validates if the user is authenticated and authorized for certain operations.
*     - LoggerService: Logs activities, warnings, and errors.
* 
* Note:
*     Ensure that any changes to this class adhere to the standard business practices and maintain the 
*     integrity and reliability of the product data.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductsController : ControllerBase
    {
        DECLARE ProductService productService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(ProductService pService, AuthService aService, LoggerService logService)
        {
            INIT productService with pService
            INIT authService with aService
            INIT logger with logService
        }

        // GET /api/products
        FUNCTION GetProducts(int? page, int? limit, string? sort) RETURNS IActionResult
        {
            TRY
            {
                List<Product> products = CALL productService.GetAllProducts(page, limit, sort)

                IF products is empty
                    RETURN Ok with message "No products found."
                END IF

                RETURN Ok with products
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving products: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/products
        FUNCTION CreateProduct(ProductRequest productRequest) RETURNS IActionResult
        {
            IF productRequest is null OR productRequest fields are not valid
                LOG warning "Invalid product request"
                RETURN BadRequest with message "Invalid product data"
            END IF

            IF NOT CALL authService.IsAuthenticatedUser()
                RETURN Unauthorized

            TRY
            {
                Product newProduct = new Product
                {
                    Name = productRequest.Name,
                    Description = productRequest.Description,
                    Price = productRequest.Price
                }

                Product createdProduct = CALL productService.SaveProduct(newProduct)

                RETURN Created with createdProduct
            }
            CATCH any exception as error
            {
                LOG error "Error while creating product: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // GET /api/products/{productId}
        FUNCTION GetProductById(int productId) RETURNS IActionResult
        {
            TRY
            {
                Product product = CALL productService.GetProductById(productId)

                IF product is null
                    RETURN NotFound with message "Product not found"
                END IF

                RETURN Ok with product
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving product by ID: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class ProductRequest
    {
        DECLARE string Name
        DECLARE string Description
        DECLARE float Price
    }

    DEFINE class Product
    {
        DECLARE int ProductId
        DECLARE string Name
        DECLARE string Description
        DECLARE float Price
    }
}
