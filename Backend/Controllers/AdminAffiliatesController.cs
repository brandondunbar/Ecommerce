/*
* AdminAffiliatesController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller manages affiliate programs and relationships 
*     for the E-Commerce platform. It offers functionalities to list all existing affiliates and to add new affiliates.
* 
* Classes:
*     AdminAffiliatesController:
*         Methods:
*             - GetAffiliates(): Retrieves a list of all affiliates associated with the platform.
*             - AddAffiliate(AffiliateRequest affiliateData): Registers a new affiliate partner with the platform.
* 
*     Affiliate:
*         Represents the structure of an affiliate in the system.
*         Properties:
*             - affiliateId: Unique identifier for the affiliate.
*             - name: Full name or company name of the affiliate.
*             - contactEmail: Contact email address for the affiliate.
*             - referralCode: Unique code used by the affiliate for referrals.
*             - registrationDate: Date and time when the affiliate was onboarded.
*             - totalReferrals: Total number of referrals made by the affiliate.
*             - successfulReferrals: Number of successful referrals that resulted in sales or signups.
*             - commissionEarned: Total commission earned by the affiliate based on successful referrals.
*             - isActive: Indicates whether the affiliate is currently active.
* 
*     AffiliateRequest:
*         Represents the data structure for adding a new affiliate. Some fields like referralCode, registrationDate, 
*         and isActive can be optional, and if not provided, the system can set default values.
* 
* Dependencies:
*     - AffiliateService: Manages CRUD operations related to affiliates.
*     - LoggerService: Logs events, warnings, and errors.
* 
* Note:
*     Proper validation and error handling should be in place to ensure that affiliate data is managed securely 
*     and reliably. Affiliates play an essential role in marketing and business growth, so their information 
*     should be handled with care.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminAffiliatesController : ControllerBase
    {
        DECLARE AffiliateService affiliateService
        DECLARE LoggerService logger

        CONSTRUCTOR(AffiliateService aService, LoggerService logService)
        {
            INIT affiliateService with aService
            INIT logger with logService
        }

        // GET /api/admin/affiliates
        FUNCTION GetAffiliates() RETURNS IActionResult
        {
            TRY
            {
                List<Affiliate> affiliates = CALL affiliateService.GetAffiliates()

                RETURN Ok with affiliates
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching affiliates: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/admin/affiliates
        FUNCTION AddAffiliate(AffiliateRequest affiliateData) RETURNS IActionResult
        {
            TRY
            {
                Affiliate newAffiliate = CALL affiliateService.AddAffiliate(affiliateData)

                RETURN StatusCode 201 with newAffiliate
            }
            CATCH any exception as error
            {
                LOG error "Error while adding affiliate: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Affiliate
    {
        DECLARE int64 affiliateId
        DECLARE string name
        DECLARE string contactEmail
        DECLARE string referralCode
        DECLARE DateTime registrationDate
        DECLARE int32 totalReferrals
        DECLARE int32 successfulReferrals
        DECLARE float commissionEarned
        DECLARE boolean isActive
    }

    DEFINE class AffiliateRequest
    {
        DECLARE string name
        DECLARE string contactEmail
        DECLARE string? referralCode  // optional
        DECLARE DateTime? registrationDate  // optional
        DECLARE boolean? isActive  // optional
    }
}
