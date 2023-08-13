/*
* AdminFeedbackController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is responsible for the management 
*     and moderation of feedback received from users on the E-Commerce platform. This could include feedback on 
*     product functionality, UI/UX, bug reports, or any other type of constructive input.
* 
* Classes:
*     AdminFeedbackController:
*         Methods:
*             - GetFeedback(string? status, string? type, int? page, int? limit): Retrieves a list of feedback 
*               entries based on filtering criteria. It supports pagination and filtering by status or type.
*             - UpdateFeedback(FeedbackUpdateData updateData): Updates the status and/or admin comment on a 
*               specific feedback entry.
* 
*     Feedback:
*         Represents the structure of a feedback entry in the system.
*         Properties:
*             - feedbackId: Unique identifier for the feedback.
*             - userId: The unique ID for the user who provided the feedback.
*             - username: The username of the person who submitted the feedback.
*             - submissionDate: The date and time the feedback was submitted.
*             - type: The type or category of the feedback (e.g., bug report, feature request).
*             - title: The title or summary of the feedback.
*             - description: Detailed description or content of the feedback.
*             - status: The current status of the feedback (e.g., pending, reviewed, resolved).
*             - adminComment: Optional comment or response from the admin.
* 
*     FeedbackUpdateData:
*         Represents the data structure for updating feedback status and/or admin comment.
*         Properties:
*             - feedbackId: The ID of the feedback to be updated.
*             - status: The new status to be set for the feedback.
*             - adminComment: Optional comment or response from the admin.
* 
* Dependencies:
*     - FeedbackService: Manages CRUD operations related to feedback entries.
*     - LoggerService: Logs events, warnings, and errors.
* 
* Note:
*     Feedback is crucial for the continuous improvement of the platform. It's essential to ensure that 
*     feedback is moderated and responded to promptly, maintaining a positive relationship with the user base.
*     Special attention should be paid to feedback related to security or performance issues.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminFeedbackController : ControllerBase
    {
        DECLARE FeedbackService feedbackService
        DECLARE LoggerService logger

        CONSTRUCTOR(FeedbackService fService, LoggerService logService)
        {
            INIT feedbackService with fService
            INIT logger with logService
        }

        // GET /api/admin/feedback
        FUNCTION GetFeedback(string? status, string? type, int? page, int? limit) RETURNS IActionResult
        {
            TRY
            {
                List<Feedback> feedbackList = CALL feedbackService.GetFeedback(status, type, page, limit)

                RETURN Ok with feedbackList
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching feedback: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/feedback
        FUNCTION UpdateFeedback(FeedbackUpdateData updateData) RETURNS IActionResult
        {
            TRY
            {
                CALL feedbackService.UpdateFeedback(updateData.feedbackId, updateData.status, updateData.adminComment)

                RETURN Ok with message "Feedback updated successfully"
            }
            CATCH FeedbackNotFoundException
            {
                RETURN NotFound with message "Feedback not found"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating feedback: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Feedback
    {
        DECLARE int feedbackId
        DECLARE int userId
        DECLARE string username
        DECLARE DateTime submissionDate
        DECLARE string type
        DECLARE string title
        DECLARE string description
        DECLARE string status
        DECLARE string? adminComment
    }

    DEFINE class FeedbackUpdateData
    {
        DECLARE int feedbackId
        DECLARE string status
        DECLARE string? adminComment
    }
}
