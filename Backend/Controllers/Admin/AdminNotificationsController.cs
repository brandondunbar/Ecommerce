/*
* AdminNotificationsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminNotificationsController class is responsible for 
*     orchestrating the sending of notifications to users. Whether it's updates, alerts, or other important 
*     messages, this controller acts as a bridge between the admin panel and the Notification Service. Given the 
*     sensitivity of notifications, especially those triggered by administrative actions, this controller 
*     ensures proper authentication before any action is taken.
* 
* Classes:
*     AdminNotificationsController:
*         Methods:
*             - SendNotification(NotificationRequest notificationRequest): 
*               Validates the request data and sends a notification to a specific user based on the details provided.
* 
*     NotificationRequest:
*         Represents the data structure for sending a notification.
*         Properties:
*             - userId: The unique ID of the user to whom the notification is to be sent.
*             - title: The title or subject of the notification.
*             - message: The main content or body of the notification.
*             - type: (Optional) The type or category of the notification, e.g., 'alert', 'info', etc.
* 
* Dependencies:
*     - NotificationService: Manages the actual sending of notifications to users.
*     - AuthService: Ensures that the user making the request is authenticated and authorized to perform the action.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while trying to send notifications.
* 
* Note:
*     When sending notifications, it's crucial to ensure they are timely, relevant, and not overly frequent to 
*     avoid overwhelming or annoying users. This controller should be used judiciously to maintain a positive 
*     user experience.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminNotificationsController : ControllerBase
    {
        DECLARE NotificationService notificationService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(NotificationService nService, AuthService aService, LoggerService logService)
        {
            INIT notificationService with nService
            INIT authService with aService
            INIT logger with logService
        }

        // POST /api/admin/notifications
        FUNCTION SendNotification(NotificationRequest notificationRequest) RETURNS IActionResult
        {
            IF notificationRequest is null OR notificationRequest fields are not valid
                RETURN BadRequest with message "Invalid request data"
            END IF

            IF NOT CALL authService.IsAuthenticatedUser()
                RETURN Unauthorized
            END IF

            TRY
            {
                CALL notificationService.SendNotificationToUser(notificationRequest.userId, notificationRequest.title, notificationRequest.message, notificationRequest.type)
                RETURN StatusCode 201 with message "Notification sent successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while sending notification: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class NotificationRequest
    {
        DECLARE int userId
        DECLARE string title
        DECLARE string message
        DECLARE string type, OPTIONAL
    }
}
