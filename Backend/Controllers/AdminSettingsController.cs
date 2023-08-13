/*
* AdminSettingsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminSettingsController class manages the global settings 
*     of the E-Commerce platform. Administrators use this class to view and modify platform-wide settings, including 
*     site title, description, maintenance mode, currency, payment methods, and shipping configurations.
* 
* Classes:
*     AdminSettingsController:
*         Methods:
*             - GetPlatformSettings(): Retrieves the current platform settings.
*             - UpdatePlatformSettings(SettingsUpdateData updateData): Updates platform-wide settings based on provided data.
* 
*     Settings:
*         Represents the global settings of the platform, including site information, maintenance mode, currency, 
*         payment methods, and shipping configurations.
* 
*     SettingsUpdateData:
*         Represents the data structure used to update the platform's settings.
* 
*     ShippingConfig:
*         Represents the platform's shipping configuration, detailing the default provider and shipping rates.
* 
*     ShippingRate:
*         Details the shipping rate for a specific region and its associated price.
* 
* Dependencies:
*     - SettingsService: Manages CRUD operations related to platform settings and interacts with the settings database.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while managing settings.
* 
* Note:
*     Proper management of platform settings is crucial for the platform's smooth operation and user experience. 
*     Administrators should be cautious when modifying certain settings, especially those that might impact the 
*     platform's availability or user access.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminSettingsController : ControllerBase
    {
        DECLARE SettingsService settingsService
        DECLARE LoggerService logger

        CONSTRUCTOR(SettingsService sService, LoggerService logService)
        {
            INIT settingsService with sService
            INIT logger with logService
        }

        // GET /api/admin/settings
        FUNCTION GetPlatformSettings() RETURNS IActionResult
        {
            TRY
            {
                Settings settings = CALL settingsService.GetPlatformSettings()

                RETURN Ok with settings
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching platform settings: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/settings
        FUNCTION UpdatePlatformSettings(SettingsUpdateData updateData) RETURNS IActionResult
        {
            TRY
            {
                CALL settingsService.UpdatePlatformSettings(updateData)

                RETURN Ok with message "Platform settings updated successfully"
            }
            CATCH InvalidDataException
            {
                RETURN BadRequest with message "Invalid request data"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating platform settings: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Settings
    {
        DECLARE string siteTitle
        DECLARE string siteDescription
        DECLARE bool maintenanceMode
        DECLARE string defaultCurrency
        DECLARE List<string> paymentMethods
        DECLARE ShippingConfig shippingConfig
        DECLARE Dictionary<string, dynamic> otherSettings
    }

    DEFINE class SettingsUpdateData
    {
        DECLARE string siteTitle
        DECLARE string siteDescription
        DECLARE bool maintenanceMode
        DECLARE string defaultCurrency
        DECLARE List<string> paymentMethods
        DECLARE ShippingConfig shippingConfig
        DECLARE Dictionary<string, dynamic> otherSettings
    }

    DEFINE class ShippingConfig
    {
        DECLARE string defaultProvider
        DECLARE List<ShippingRate> rates
    }

    DEFINE class ShippingRate
    {
        DECLARE string region
        DECLARE float price
    }
}
