/*
* UserProfileController.cs
*
* Description:
*     Situated in the ECommerceApp.Controllers namespace, this controller is devoted to managing operations 
*     tied to the authenticated user's profile. It enables the viewing and updating of profile details, 
*     password modification, and account deletion.
* 
* Classes:
*     UserProfileController:
*         Methods:
*             - GetProfile(): Fetches the profile details of the authenticated user.
*             - UpdateProfile(UserProfileUpdateRequest updateRequest): Updates the profile data of the authenticated user.
*             - DeleteAccount(): Facilitates the authenticated user in deleting their account.
*             - ChangePassword(ChangePasswordRequest passwordRequest): Empowers the authenticated user to alter their password.
* 
*     UserProfileUpdateRequest:
*         Depicts the request structure for updating user profile information.
* 
*     ChangePasswordRequest:
*         Depicts the request structure for changing the user's password.
* 
* Dependencies:
*     - UserService: Offers methods specific to user operations, including fetching and modifying user details.
*     - PasswordHasher: Aids in the hashing and comparison of passwords.
*     - LoggerService: Logs events, cautions, and errors.
* 
* Note:
*     It's paramount to verify the user's authentication before allowing access to the methods. Alterations 
*     to this controller should prioritize preserving security and privacy, especially considering the sensitivity 
*     of user profile data.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/



IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class UserProfileController : ControllerBase
    {
        DECLARE UserService userService
        DECLARE PasswordHasher passwordHasher
        DECLARE LoggerService logger

        CONSTRUCTOR(UserService uService, PasswordHasher pHasher, LoggerService logService)
        {
            INIT userService with uService
            INIT passwordHasher with pHasher
            INIT logger with logService
        }

        // GET /api/users/profile
        FUNCTION GetProfile() RETURNS IActionResult
        {
            DECLARE authenticatedUserId from JWT

            IF authenticatedUserId is NOT present
                RETURN Unauthorized
            END IF

            User user = CALL userService.GetUserById(authenticatedUserId)

            IF user is null
                LOG warning "User not found"
                RETURN NotFound with message "User profile not found"
            END IF

            RETURN Ok with user details (excluding sensitive fields)
        }

        // PUT /api/users/profile
        FUNCTION UpdateProfile(UserProfileUpdateRequest updateRequest) RETURNS IActionResult
        {
            DECLARE authenticatedUserId from JWT

            IF authenticatedUserId is NOT present
                RETURN Unauthorized
            END IF

            User user = CALL userService.GetUserById(authenticatedUserId)

            IF user is null
                LOG warning "User not found"
                RETURN NotFound with message "User profile not found"
            END IF

            // Update user fields based on updateRequest
            user.Username = updateRequest.Username
            user.Email = updateRequest.Email

            CALL userService.UpdateUser(user)

            RETURN Ok with updated user details (excluding sensitive fields)
        }

        // DELETE /api/users/profile
        FUNCTION DeleteAccount() RETURNS IActionResult
        {
            DECLARE authenticatedUserId from JWT

            IF authenticatedUserId is NOT present
                RETURN Unauthorized
            END IF

            CALL userService.DeleteUser(authenticatedUserId)

            RETURN Ok with message "User account deleted successfully"
        }

        // PUT /api/users/profile/password
        FUNCTION ChangePassword(ChangePasswordRequest passwordRequest) RETURNS IActionResult
        {
            DECLARE authenticatedUserId from JWT

            IF authenticatedUserId is NOT present
                RETURN Unauthorized
            END IF

            IF passwordRequest.newPassword != passwordRequest.confirmPassword
                RETURN BadRequest with message "Passwords do not match"
            END IF

            User user = CALL userService.GetUserById(authenticatedUserId)

            IF user is null OR passwordHasher.CheckPassword(user.PasswordHash, passwordRequest.currentPassword) is NOT valid
                RETURN Unauthorized with message "Current password is incorrect"
            END IF

            user.PasswordHash = CALL passwordHasher.HashPassword(passwordRequest.newPassword)

            CALL userService.UpdateUserPassword(user)

            RETURN Ok with message "Password changed successfully"
        }
    }

    DEFINE class UserProfileUpdateRequest
    {
        DECLARE string Username
        DECLARE string Email
    }

    DEFINE class ChangePasswordRequest
    {
        DECLARE string currentPassword
        DECLARE string newPassword
        DECLARE string confirmPassword
    }
}
