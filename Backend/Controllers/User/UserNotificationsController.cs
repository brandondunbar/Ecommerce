/*
* UserNotificationsController.cs
*
* Description:
*     This controller is part of the ECommerceApp.Controllers namespace and oversees functionalities related 
*     to user notifications within the ECommerceApp. It offers features that allow authenticated users to view 
*     their notifications and mark them as read, either on an individual basis or collectively.
* 
* Classes:
*     UserNotificationsController:
*         Methods:
*             - GetNotifications(string status = "all"): Allows the authenticated user to fetch their notifications based on status.
*             - MarkNotificationsAsRead(NotificationActionRequest actionRequest): Enables the authenticated user to set specific notifications or all notifications to "read" status.
* 
*     NotificationActionRequest:
*         Represents the request structure for marking notifications as read.
* 
*     Notification:
*         Represents an individual user notification.
* 
* Dependencies:
*     - NotificationService: Provides methods and functionalities related to user notifications.
*     - AuthService: Handles user authentication and related processes.
*     - LoggerService: Responsible for logging events, warnings, and errors.
* 
* Note:
*     It's essential to ensure users are authenticated before they can access the features provided by this controller.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class UserNotificationsController : ControllerBase
    {
        DECLARE NotificationService notificationService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(NotificationService notifService, AuthService auth, LoggerService log)
        {
            INIT notificationService with notifService
            INIT authService with auth
            INIT logger with log
        }

        // GET /api/users/notifications
        FUNCTION GetNotifications(string status = "all") RETURNS IActionResult
        {
            IF NOT CALL authService.IsUserAuthenticated()
                RETURN Unauthorized
            END IF

            TRY
            {
                List<Notification> notifications = CALL notificationService.GetNotificationsForUser(status)
                RETURN Ok with notifications
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching notifications: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/users/notifications
        FUNCTION MarkNotificationsAsRead(NotificationActionRequest actionRequest) RETURNS IActionResult
        {
            IF NOT CALL authService.IsUserAuthenticated()
                RETURN Unauthorized
            END IF

            IF actionRequest is null OR actionRequest fields are not valid
                LOG warning "Invalid action request"
                RETURN BadRequest with message "Invalid action data"
            END IF

            TRY
            {
                IF actionRequest.action equals "all"
                    CALL notificationService.MarkAllNotificationsAsRead()
                ELSE IF actionRequest.action equals "selected" AND actionRequest.notificationIds is not null
                    CALL notificationService.MarkSelectedNotificationsAsRead(actionRequest.notificationIds)
                END IF
                
                RETURN Ok with message "Notifications marked as read successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while marking notifications as read: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class NotificationActionRequest
    {
        DECLARE string action
        DECLARE List<int> notificationIds
    }

    DEFINE class Notification
    {
        DECLARE int id
        DECLARE string title
        DECLARE string message
        DECLARE dateTime date
        DECLARE string status
    }
}
