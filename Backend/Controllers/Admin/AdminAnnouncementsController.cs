/*
* AdminAnnouncementsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller handles the management and broadcasting 
*     of announcements on the E-Commerce platform. It offers functionalities to retrieve existing announcements 
*     and to create new announcements.
* 
* Classes:
*     AdminAnnouncementsController:
*         Methods:
*             - GetAnnouncements(): Retrieves a list of all announcements available on the platform.
*             - CreateAnnouncement(AnnouncementCreate requestData): Creates a new announcement based on the 
*               provided data.
* 
*     Announcement:
*         Represents the structure of an announcement in the system.
*         Properties:
*             - announcementId: Unique identifier for the announcement.
*             - title: The main heading or title of the announcement.
*             - message: The actual content or body of the announcement.
*             - timestamp: The date and time when the announcement was made.
*             - (Any other properties related to the Announcement schema would be listed here.)
* 
*     AnnouncementCreate:
*         Represents the data structure for creating a new announcement. This may differ slightly from the 
*         Announcement structure if there are fields automatically populated by the system.
*         Properties:
*             - title: The main heading or title for the new announcement.
*             - message: The actual content or body of the new announcement.
*             - (Any other properties specific to the AnnouncementCreate schema would be listed here.)
* 
* Dependencies:
*     - AnnouncementService: Manages CRUD operations related to announcements.
*     - LoggerService: Logs events, warnings, and errors.
* 
* Note:
*     Announcements are crucial for communicating important information to the users of the platform. Whether 
*     it's about new features, maintenance periods, or other updates, ensuring the accuracy and clarity of 
*     these announcements is essential. Proper validation should be in place to ensure announcements are 
*     conveyed correctly and timely.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminAnnouncementsController : ControllerBase
    {
        DECLARE AnnouncementService announcementService
        DECLARE LoggerService logger

        CONSTRUCTOR(AnnouncementService aService, LoggerService logService)
        {
            INIT announcementService with aService
            INIT logger with logService
        }

        // GET /api/admin/announcements
        FUNCTION GetAnnouncements() RETURNS IActionResult
        {
            TRY
            {
                List<Announcement> announcements = CALL announcementService.GetAnnouncements()

                RETURN Ok with announcements
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching announcements: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/admin/announcements
        FUNCTION CreateAnnouncement(AnnouncementCreate requestData) RETURNS IActionResult
        {
            TRY
            {
                Announcement newAnnouncement = CALL announcementService.CreateAnnouncement(requestData)

                RETURN StatusCode 201 with newAnnouncement
            }
            CATCH any exception as error
            {
                LOG error "Error while creating an announcement: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Announcement
    {
        DECLARE int64 announcementId
        DECLARE string title
        DECLARE string message
        DECLARE DateTime timestamp
        // Add other fields as per the schema reference
    }

    DEFINE class AnnouncementCreate
    {
        DECLARE string title
        DECLARE string message
        // Add other fields specific to announcement creation as per the schema reference
    }
}
