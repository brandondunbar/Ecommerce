/*
* UserWishlistsController.cs
*
* Description:
*     This controller, part of the ECommerceApp.Controllers namespace, manages operations related to user wishlists. 
*     Authenticated users can view their existing wishlists and create new ones via the functionalities offered by this controller.
* 
* Classes:
*     UserWishlistsController:
*         Methods:
*             - GetWishlists(): Lets the authenticated user retrieve all their wishlists.
*             - CreateWishlist(WishlistRequest wishlistRequest): Allows an authenticated user to set up a new wishlist.
* 
*     WishlistRequest:
*         Represents the data structure for creating or updating a wishlist.
* 
*     WishlistItem:
*         Represents an individual item or product within a user's wishlist.
* 
*     Wishlist:
*         Represents the structure of a user's wishlist.
*         Properties:
*             - Id: The unique ID for the wishlist.
*             - UserId: The ID of the user who owns the wishlist.
*             - Name: The name of the wishlist.
*             - Description: A brief description of the wishlist.
*             - Items: A list of items or products added to the wishlist.
* 
* Dependencies:
*     - WishlistService: Provides operations related to wishlists.
*     - AuthService: Manages user authentication functionalities.
*     - LoggerService: Logs information, warnings, and errors.
* 
* Note:
*     Ensure the user is authenticated before they can access the functionalities of this controller.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class UserWishlistsController : ControllerBase
    {
        DECLARE WishlistService wishlistService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(WishlistService wService, AuthService aService, LoggerService logService)
        {
            INIT wishlistService with wService
            INIT authService with aService
            INIT logger with logService
        }

        // GET /api/users/wishlists
        FUNCTION GetWishlists() RETURNS IActionResult
        {
            TRY
            {
                User authenticatedUser = CALL authService.GetAuthenticatedUser()

                IF authenticatedUser is null
                    RETURN Unauthorized
                END IF

                List<Wishlist> wishlists = CALL wishlistService.GetWishlistsForUser(authenticatedUser.Id)

                RETURN Ok with wishlists
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving wishlists: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/users/wishlists
        FUNCTION CreateWishlist(WishlistRequest wishlistRequest) RETURNS IActionResult
        {
            IF wishlistRequest is null OR wishlistRequest fields are not valid
                LOG warning "Invalid wishlist request"
                RETURN BadRequest with message "Invalid wishlist data"
            END IF

            TRY
            {
                User authenticatedUser = CALL authService.GetAuthenticatedUser()

                IF authenticatedUser is null
                    RETURN Unauthorized
                END IF

                Wishlist newWishlist = new Wishlist
                {
                    UserId = authenticatedUser.Id,
                    Name = wishlistRequest.Name,
                    Description = wishlistRequest.Description,
                    Items = wishlistRequest.Items
                }

                CALL wishlistService.SaveWishlist(newWishlist)

                RETURN Created with newWishlist
            }
            CATCH any exception as error
            {
                LOG error "Error while creating wishlist: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class WishlistRequest
    {
        DECLARE int Id
        DECLARE string Name
        DECLARE string Description
        DECLARE List<WishlistItem> Items
    }

    DEFINE class WishlistItem
    {
        DECLARE int ProductId
        DECLARE string ProductName
    }

    DEFINE class Wishlist
    {
        DECLARE int Id
        DECLARE int UserId
        DECLARE string Name
        DECLARE string Description
        DECLARE List<WishlistItem> Items
    }
}
