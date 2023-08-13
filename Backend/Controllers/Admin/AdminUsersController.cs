/*
* AdminUsersController.cs
*
* Description:
*     The AdminUsersController class, located in the ECommerceApp.Controllers namespace, oversees user management within 
*     the platform. Through this class, administrators can perform a variety of user-related tasks, including listing 
*     all users, adding a new user, bulk updating users, and bulk deleting users.
* 
* Classes:
*     AdminUsersController:
*         Methods:
*             - ListAllUsers(): Retrieves a list of all users on the platform.
*             - AddNewUser(UserCreateRequest userRequest): Adds a new user to the platform.
*             - BulkUpdateUsers(List<UserUpdateRequest> usersToUpdate): Allows bulk updating of user data.
*             - BulkDeleteUsers(List<int> userIds): Enables the bulk deletion of users based on a list of user IDs.
* 
*     UserCreateRequest:
*         Data class for capturing details required for creating a new user. Contains fields such as username, email, 
*         and password.
* 
*     UserUpdateRequest:
*         Data class to capture details for updating user information. Fields can include username, email, name, role, 
*         avatar URL, and other pertinent user details.
* 
* Dependencies:
*     - UserService: Manages user-related operations, including retrieval, creation, updating, and deletion of users.
*     - AuthService: Handles user authentication and associated operations.
*     - LoggerService: Logs various activities, warnings, and errors.
* 
* Note:
*     Effective user management is vital for the smooth running of the platform. Administrators should ensure that 
*     user data is accurate and that user roles and permissions are appropriately set to maintain security.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminUsersController : ControllerBase
    {
        DECLARE UserService userService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(UserService uService, AuthService aService, LoggerService logService)
        {
            INIT userService with uService
            INIT authService with aService
            INIT logger with logService
        }

        // GET /api/admin/users
        FUNCTION ListAllUsers() RETURNS IActionResult
        {
            TRY
            {
                List<User> users = CALL userService.GetAllUsers()

                RETURN Ok with users
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving user list: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/admin/users
        FUNCTION AddNewUser(UserCreateRequest userRequest) RETURNS IActionResult
        {
            IF userRequest is null OR userRequest fields are not valid
                RETURN BadRequest with message "Invalid request data"
            END IF

            TRY
            {
                CALL userService.AddUser(userRequest)

                RETURN StatusCode 201 with message "User added successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while adding new user: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/users
        FUNCTION BulkUpdateUsers(List<UserUpdateRequest> usersToUpdate) RETURNS IActionResult
        {
            TRY
            {
                CALL userService.BulkUpdateUsers(usersToUpdate)

                RETURN Ok with message "Users updated successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error during bulk user update: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // DELETE /api/admin/users
        FUNCTION BulkDeleteUsers(List<int> userIds) RETURNS IActionResult
        {
            TRY
            {
                CALL userService.BulkDeleteUsers(userIds)

                RETURN Ok with message "Users deleted successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error during bulk user deletion: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class UserCreateRequest
    {
        DECLARE string username
        DECLARE string email
        DECLARE string password
    }

    DEFINE class UserUpdateRequest
    {
        DECLARE string username, OPTIONAL
        DECLARE string email, OPTIONAL
        DECLARE string firstName, OPTIONAL
        DECLARE string lastName, OPTIONAL
        DECLARE string role, OPTIONAL
        DECLARE bool isActive, OPTIONAL
        DECLARE string avatarUrl, OPTIONAL
        DECLARE string address, OPTIONAL
        DECLARE string phone, OPTIONAL
    }
}
