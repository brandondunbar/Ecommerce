/*
* AdminUserRoleController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminUserRoleController class is responsible for managing
*     user roles within the platform. Through this class, administrators can list, assign, update, or remove roles 
*     associated with a specific user.
* 
* Classes:
*     AdminUserRoleController:
*         Methods:
*             - ListRolesForUser(int userId): Lists the roles associated with a specific user.
*             - AssignOrUpdateRolesForUser(int userId, List<string> roles): Assigns or updates roles for a specific user.
*             - RemoveRolesFromUser(int userId, List<string> roles): Removes specified roles from a user.
* 
* Dependencies:
*     - UserRoleService: Facilitates operations related to user roles, interacting with the user roles database.
*     - LoggerService: Captures and logs events, warnings, and errors, especially those related to user role operations.
* 
* Note:
*     Roles are essential in determining the permissions and access levels of users on the platform. Proper management 
*     ensures that users have the correct privileges for their responsibilities and that sensitive areas of the platform
*     are adequately protected.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminUserRoleController : ControllerBase
    {
        DECLARE UserRoleService userRoleService
        DECLARE LoggerService logger

        CONSTRUCTOR(UserRoleService urService, LoggerService logService)
        {
            INIT userRoleService with urService
            INIT logger with logService
        }

        // GET /api/admin/users/{userId}/roles
        FUNCTION ListRolesForUser(int userId) RETURNS IActionResult
        {
            TRY
            {
                List<string> roles = CALL userRoleService.GetRolesByUserId(userId)

                IF roles is empty OR null
                    RETURN NotFound with message "User not found"
                END IF

                RETURN Ok with roles
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving roles for user {userId}: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/users/{userId}/roles
        FUNCTION AssignOrUpdateRolesForUser(int userId, List<string> roles) RETURNS IActionResult
        {
            TRY
            {
                CALL userRoleService.AssignOrUpdateRoles(userId, roles)

                RETURN Ok with message "Roles updated successfully"
            }
            CATCH any exception as error when user not found
            {
                RETURN NotFound with message "User not found"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating roles for user {userId}: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // DELETE /api/admin/users/{userId}/roles
        FUNCTION RemoveRolesFromUser(int userId, List<string> roles) RETURNS IActionResult
        {
            TRY
            {
                CALL userRoleService.RemoveRoles(userId, roles)

                RETURN Ok with message "Roles removed successfully"
            }
            CATCH any exception as error when user not found
            {
                RETURN NotFound with message "User not found"
            }
            CATCH any exception as error
            {
                LOG error "Error while removing roles from user {userId}: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }
}
