/*
* ProductReviewsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller manages the product review functionality 
*     on the E-Commerce platform. It provides endpoints for fetching reviews of a product and for adding new reviews.
* 
* Classes:
*     ProductReviewsController:
*         Methods:
*             - GetReviewsForProduct(int productId): Fetches all the reviews for a given product. It ensures the product exists 
*               and retrieves its associated reviews.
*             - AddReviewForProduct(int productId, ReviewInput reviewInput): Allows users to add a new review for a product. 
*               Validates the review input, checks for authentication, and ensures the associated product exists.
* 
*     Review:
*         Represents a product review in the application.
*         Properties:
*             - Id: The unique identifier of the review.
*             - ProductId: The ID of the associated product.
*             - Title: The title of the review.
*             - Content: The main content or body of the review.
*             - Rating: The numerical rating given in the review.
*             - Date: The timestamp when the review was added.
* 
*     ReviewInput:
*         Represents the input format when adding a new review.
*         Properties:
*             - Title: The title of the new review.
*             - Content: The main content or body of the new review.
*             - Rating: The numerical rating to be given in the new review.
* 
* Dependencies:
*     - ReviewService: Manages CRUD operations related to product reviews.
*     - ProductService: Manages product-related operations and checks for product existence.
*     - AuthService: Handles user authentication and retrieves authenticated user details.
*     - LoggerService: Logs activities, warnings, and errors.
* 
* Note:
*     Ensure that the review functionality upholds the principle of unbiased feedback. Ensure user privacy 
*     in reviews and always validate and sanitize review input to prevent potential issues and vulnerabilities.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductReviewsController : ControllerBase
    {
        DECLARE ReviewService reviewService
        DECLARE ProductService productService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(ReviewService rService, ProductService pService, AuthService aService, LoggerService logService)
        {
            INIT reviewService with rService
            INIT productService with pService
            INIT authService with aService
            INIT logger with logService
        }

        // GET /api/products/{productId}/reviews
        FUNCTION GetReviewsForProduct(int productId) RETURNS IActionResult
        {
            TRY
            {
                IF CALL productService.ProductExists(productId) IS FALSE
                    RETURN NotFound with message "Product not found"
                END IF

                List<Review> reviews = CALL reviewService.GetReviewsForProduct(productId)

                RETURN Ok with reviews
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving reviews: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/products/{productId}/reviews
        FUNCTION AddReviewForProduct(int productId, ReviewInput reviewInput) RETURNS IActionResult
        {
            IF reviewInput is null OR reviewInput fields are not valid
                LOG warning "Invalid review input"
                RETURN BadRequest with message "Invalid review data"
            END IF

            User authenticatedUser = CALL authService.GetAuthenticatedUser()
            IF authenticatedUser is null
                RETURN Unauthorized
            END IF

            IF CALL productService.ProductExists(productId) IS FALSE
                RETURN NotFound with message "Product not found"
            END IF

            TRY
            {
                Review newReview = new Review
                {
                    ProductId = productId,
                    Title = reviewInput.Title,
                    Content = reviewInput.Content,
                    Rating = reviewInput.Rating,
                    UserId = authenticatedUser.Id,
                    Date = CURRENT_TIMESTAMP
                }

                CALL reviewService.AddReview(newReview)

                RETURN Created with newReview
            }
            CATCH any exception as error
            {
                LOG error "Error while adding review: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Review
    {
        DECLARE int Id
        DECLARE int ProductId
        DECLARE string Title
        DECLARE string Content
        DECLARE int Rating
        DECLARE timestamp Date
    }

    DEFINE class ReviewInput
    {
        DECLARE string Title
        DECLARE string Content
        DECLARE int Rating
    }
}
