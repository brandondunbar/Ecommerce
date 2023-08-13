/*
* ProductCategoriesController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller handles operations related to product categories 
*     within the E-Commerce platform. It provides endpoints for fetching all product categories and for adding new categories.
* 
* Classes:
*     ProductCategoriesController:
*         Methods:
*             - GetAllCategories(): Retrieves a list of all product categories from the platform. 
*               It returns a message if no categories are found.
*             - CreateCategory(CategoryRequest categoryRequest): Validates the incoming category request and creates 
*               a new product category if valid and the user is authenticated.
* 
*     CategoryRequest:
*         Represents the data structure for creating a new product category. 
*         Properties:
*             - Name: The name of the category.
*             - Description: A brief description of the category.
*             - ParentCategoryId: (Optional) The ID of the parent category, if this category is a sub-category.
* 
*     Category:
*         Represents a product category within the system. 
*         Properties:
*             - Id: The unique ID for the category.
*             - Name: The name of the category.
*             - Description: A brief description of the category.
*             - ParentCategoryId: (Optional) The ID of the parent category, if this category is a sub-category.
* 
* Dependencies:
*     - CategoryService: Manages operations related to product categories, including CRUD operations.
*     - AuthService: Manages user authentication and authorization checks.
*     - LoggerService: Logs activities, warnings, and errors.
* 
* Note:
*     Ensure proper validation and verification before any category creation or modification. Categories play a crucial role 
*     in product organization and navigation, so data integrity is vital.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductCategoriesController : ControllerBase
    {
        DECLARE CategoryService categoryService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(CategoryService cService, AuthService aService, LoggerService logService)
        {
            INIT categoryService with cService
            INIT authService with aService
            INIT logger with logService
        }

        // GET /api/products/categories
        FUNCTION GetAllCategories() RETURNS IActionResult
        {
            TRY
            {
                List<Category> categories = CALL categoryService.GetAllCategories()

                IF categories is empty
                    RETURN Ok with message "No categories found."
                END IF

                RETURN Ok with categories
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving categories: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/products/categories
        FUNCTION CreateCategory(CategoryRequest categoryRequest) RETURNS IActionResult
        {
            IF categoryRequest is null OR categoryRequest fields are not valid
                LOG warning "Invalid category request"
                RETURN BadRequest with message "Invalid category data"
            END IF

            IF NOT CALL authService.IsAuthenticatedUser()
                RETURN Unauthorized

            TRY
            {
                Category newCategory = new Category
                {
                    Name = categoryRequest.Name,
                    Description = categoryRequest.Description,
                    ParentCategoryId = categoryRequest.ParentCategoryId
                }

                Category createdCategory = CALL categoryService.SaveCategory(newCategory)

                RETURN Created with createdCategory
            }
            CATCH any exception as error
            {
                LOG error "Error while creating category: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class CategoryRequest
    {
        DECLARE string Name
        DECLARE string Description
        DECLARE int? ParentCategoryId
    }

    DEFINE class Category
    {
        DECLARE int Id
        DECLARE string Name
        DECLARE string Description
        DECLARE int? ParentCategoryId
    }
}
