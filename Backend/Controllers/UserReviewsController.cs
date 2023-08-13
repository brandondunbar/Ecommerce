/*
* UserReviewsController.cs
*
* Description:
*     Situated in the ECommerceApp.Controllers namespace, this controller is dedicated to managing operations 
*     related to user product reviews. It enables authenticated users to both view their product reviews and 
*     submit new ones.
* 
* Classes:
*     UserReviewsController:
*         Methods:
*             - GetReviews(): Retrieves the product reviews for the authenticated user.
*             - CreateReview(ReviewRequest reviewRequest): Enables the authenticated user to submit a product review.
* 
*     Review:
*         Represents an individual product review.
*         Properties:
*             - Id: Unique identifier for the review.
*             - ProductId: Identifier for the reviewed product.
*             - Title: Review title or header.
*             - Content: Detailed content of the review.
*             - Rating: Rating given to the product, ranging from 1 to 5.
*             - Date: Date and time the review was submitted.
* 
*     ReviewRequest:
*         Represents the data structure for a review submission.
* 
* Dependencies:
*     - ReviewService: Service dedicated to handling operations concerning product reviews.
*     - AuthService: Service focused on managing user authentication.
*     - LoggerService: Service that logs events, warnings, and errors.
* 
* Note:
*     Ensure that users are authenticated before accessing the functionalities provided by this controller.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/



MODULE ECommerceApp.Controllers

    CLASS UserReviewsController

        // Dependency Services
        ReviewService
        AuthService
        LoggerService

        CONSTRUCTOR(UserReviewsController)
            INITIALIZE ReviewService
            INITIALIZE AuthService
            INITIALIZE LoggerService
        END CONSTRUCTOR

        FUNCTION GetReviews() -> ActionResult
            IF NOT AuthService.IsUserAuthenticated THEN
                RETURN Unauthorized response
            END IF

            TRY
                userReviews <- CALL ReviewService to fetch user reviews
                RETURN userReviews as OK response
            CATCH any errors
                LOG the error using LoggerService
                RETURN InternalServerError response
            END TRY
        END FUNCTION

        FUNCTION CreateReview(ReviewRequest) -> ActionResult
            IF NOT ReviewRequest.IsValid THEN
                RETURN BadRequest response
            END IF

            IF NOT AuthService.IsUserAuthenticated THEN
                RETURN Unauthorized response
            END IF

            TRY
                newReview <- CALL ReviewService to create a review using ReviewRequest
                RETURN newReview as Created response
            CATCH any errors
                LOG the error using LoggerService
                RETURN InternalServerError response
            END TRY
        END FUNCTION

    END CLASS

    CLASS ReviewRequest
        ProductId
        Title
        Content
        Rating

        FUNCTION IsValid() -> BOOLEAN
            IF all required properties are set and rating is between 1 to 5 THEN
                RETURN TRUE
            ELSE
                RETURN FALSE
            END IF
        END FUNCTION
    END CLASS

    CLASS Review
        Id
        ProductId
        Title
        Content
        Rating
        Date
    END CLASS

END MODULE
