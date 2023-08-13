/*
* AdminReviewsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminReviewsController class is responsible for the management 
*     and oversight of product reviews on the E-Commerce platform. This class allows administrators to view, moderate, 
*     and delete reviews based on specific criteria.
* 
* Classes:
*     AdminReviewsController:
*         Methods:
*             - GetReviews(int? productId, int? userId, string? status, int? page, int? limit): Retrieves a list of reviews 
*               based on provided filtering criteria.
*             - UpdateReviewStatus(ReviewUpdateData updateData): Allows administrators to modify the status, content, or 
*               add comments to a specific review.
*             - DeleteReview(int reviewId): Enables the removal of a particular review from the platform.
* 
*     Review:
*         Represents a product review, detailing the product's ID, title, content, rating, and the date it was posted.
* 
*     ReviewUpdateData:
*         Represents the data structure used to update a review's status, content, or add an administrative comment.
* 
* Dependencies:
*     - ReviewService: Manages CRUD operations for reviews, and interacts with the reviews database.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while managing reviews.
* 
* Note:
*     Review management is crucial for maintaining the integrity and reputation of the platform. Administrators should 
*     ensure that reviews follow the platform's guidelines and are free from inappropriate content. At the same time, 
*     transparency and fairness in moderating reviews are essential to retain user trust.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminReviewsController : ControllerBase
    {
        DECLARE ReviewService reviewService
        DECLARE LoggerService logger

        CONSTRUCTOR(ReviewService rService, LoggerService logService)
        {
            INIT reviewService with rService
            INIT logger with logService
        }

        // GET /api/admin/reviews
        FUNCTION GetReviews(int? productId, int? userId, string? status, int? page, int? limit) RETURNS IActionResult
        {
            TRY
            {
                List<Review> reviews = CALL reviewService.GetReviews(productId, userId, status, page, limit)

                RETURN Ok with reviews
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching reviews: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/reviews
        FUNCTION UpdateReviewStatus(ReviewUpdateData updateData) RETURNS IActionResult
        {
            TRY
            {
                CALL reviewService.UpdateReviewStatus(updateData.reviewId, updateData.status, updateData.adminComment, updateData.updatedContent)

                RETURN Ok with message "Review status updated successfully"
            }
            CATCH ReviewNotFoundException
            {
                RETURN NotFound with message "Review not found"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating review status: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // DELETE /api/admin/reviews
        FUNCTION DeleteReview(int reviewId) RETURNS IActionResult
        {
            TRY
            {
                CALL reviewService.DeleteReview(reviewId)

                RETURN NoContent //204 No Content status
            }
            CATCH ReviewNotFoundException
            {
                RETURN NotFound with message "Review not found"
            }
            CATCH any exception as error
            {
                LOG error "Error while deleting review: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Review
    {
        DECLARE int id
        DECLARE int productId
        DECLARE string title
        DECLARE string content
        DECLARE int rating
        DECLARE DateTime date
    }

    DEFINE class ReviewUpdateData
    {
        DECLARE int reviewId
        DECLARE string status
        DECLARE string? adminComment
        DECLARE string? updatedContent
    }
}
