/*
* AdminPartnershipsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminPartnershipsController class oversees the 
*     partnerships and collaborations the E-Commerce platform has with other businesses or entities. This 
*     class allows the platform's administrators to view existing partnerships and add new ones. Partnerships 
*     can range from collaborations and sponsorships to integrations with other services.
* 
* Classes:
*     AdminPartnershipsController:
*         Methods:
*             - GetPartnerships(): Retrieves a list of all business partnerships associated with the platform.
*             - AddPartnership(PartnershipRequest partnershipData): Registers a new business partnership or 
*               collaboration with the platform.
* 
*     Partnership:
*         Represents a partnership or collaboration with another entity.
*         Properties:
*             - partnershipId: Unique identifier for the partnership.
*             - partnerName: Name of the partner organization or business.
*             - contactPerson: Name of the primary contact person at the partner organization.
*             - contactEmail: Email address for communication with the partner.
*             - partnershipType: Type or nature of the partnership (e.g., "Collaboration", "Integration").
*             - startDate: Date the partnership began.
*             - endDate: (Optional) Date the partnership is set to end.
*             - terms: Specific terms and conditions of the partnership.
*             - benefits: Benefits accrued from the partnership, for both parties.
*             - isActive: Indicates the active status of the partnership.
* 
*     PartnershipRequest:
*         Represents the data structure required when adding a new partnership.
* 
* Dependencies:
*     - PartnershipService: Manages CRUD operations related to partnerships by interacting with the database.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while managing partnerships.
* 
* Note:
*     Given the significance of partnerships in expanding business operations and offerings, it's crucial 
*     to handle partnership data with care. Proper documentation and understanding of each partnership's 
*     terms are essential to maintain good relations with partner entities.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminPartnershipsController : ControllerBase
    {
        DECLARE PartnershipService partnershipService
        DECLARE LoggerService logger

        CONSTRUCTOR(PartnershipService pService, LoggerService logService)
        {
            INIT partnershipService with pService
            INIT logger with logService
        }

        // GET /api/admin/partnerships
        FUNCTION GetPartnerships() RETURNS IActionResult
        {
            TRY
            {
                List<Partnership> partnerships = CALL partnershipService.GetPartnerships()

                RETURN Ok with partnerships
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching partnerships: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/admin/partnerships
        FUNCTION AddPartnership(PartnershipRequest partnershipData) RETURNS IActionResult
        {
            TRY
            {
                Partnership newPartnership = CALL partnershipService.AddPartnership(partnershipData)

                RETURN StatusCode 201 with newPartnership
            }
            CATCH any exception as error
            {
                LOG error "Error while adding partnership: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Partnership
    {
        DECLARE int64 partnershipId
        DECLARE string partnerName
        DECLARE string contactPerson
        DECLARE string contactEmail
        DECLARE string partnershipType
        DECLARE DateTime startDate
        DECLARE DateTime? endDate  // optional
        DECLARE string terms
        DECLARE string benefits
        DECLARE boolean isActive
    }

    DEFINE class PartnershipRequest
    {
        DECLARE string partnerName
        DECLARE string contactPerson
        DECLARE string contactEmail
        DECLARE string partnershipType
        DECLARE DateTime startDate
        DECLARE DateTime? endDate  // optional
        DECLARE string terms
        DECLARE string benefits
        DECLARE boolean? isActive  // optional
    }
}
