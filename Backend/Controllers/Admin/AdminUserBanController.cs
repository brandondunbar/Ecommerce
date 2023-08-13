/*
* AdminUserBanController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminUserBanController is responsible for managing the 
*     banning and unbanning of users on the platform. Administrators use this class to ban a specific user, providing 
*     a reason for the ban and an optional duration. They can also unban a user, removing any restrictions placed on 
*     their account.
* 
* Classes:
*     AdminUserBanController:
*         Methods:
*             - BanUser(int userId, string reason, DateTime? duration): Bans a specific user for a provided reason 
*               and optional duration.
*             - UnbanUser(int userId): Unbans a specific user, lifting restrictions from their account.
* 
* Dependencies:
*     - UserBanService: Manages user ban operations, facilitating the banning and unbanning of users while interacting 
*       with the user database.
*     - LoggerService: Logs events, warnings, and errors. In this context, it captures issues related to banning and 
*       unbanning operations.
* 
* Note:
*     Banning is a sensitive operation, and administrators should exercise caution when banning users to ensure that 
*     actions are justifiable. It's also essential to monitor the reasons for banning to ensure that platform rules 
*     and guidelines are clear and consistently enforced.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminUserBanController : ControllerBase
    {
        DECLARE UserBanService userBanService
        DECLARE LoggerService logger

        CONSTRUCTOR(UserBanService ubService, LoggerService logService)
        {
            INIT userBanService with ubService
            INIT logger with logService
        }

        // POST /api/admin/users/{userId}/bans
        FUNCTION BanUser(int userId, string reason, DateTime? duration = null) RETURNS IActionResult
        {
            TRY
            {
                CALL userBanService.BanUser(userId, reason, duration)

                RETURN Ok with message "User banned successfully"
            }
            CATCH any exception as error when user not found
            {
                RETURN NotFound with message "User not found"
            }
            CATCH any exception as error
            {
                LOG error "Error while banning user {userId}: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // DELETE /api/admin/users/{userId}/bans
        FUNCTION UnbanUser(int userId) RETURNS IActionResult
        {
            TRY
            {
                BOOL success = CALL userBanService.UnbanUser(userId)

                IF NOT success
                    RETURN NotFound with message "User not found or not banned"
                END IF

                RETURN Ok with message "User unbanned successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while unbanning user {userId}: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }
}
