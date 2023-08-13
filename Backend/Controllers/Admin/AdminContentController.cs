/*
* AdminContentController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller oversees the management and delivery 
*     of static and dynamic content on the E-Commerce platform. This includes static pages such as 'About Us' or 
*     'Terms of Service' and promotional banners that can be displayed at different positions on the platform.
* 
* Classes:
*     AdminContentController:
*         Methods:
*             - GetContentPages(): Retrieves a list of all static content pages available on the platform.
*             - GetPromotionalBanners(): Fetches a list of all promotional banners currently displayed or scheduled on the platform.
*             - CreatePromotionalBanner(BannerRequest bannerData): Creates a new promotional banner based on provided data.
* 
*     ContentPage:
*         Represents the structure of a static content page in the system.
*         Properties:
*             - pageId: Unique identifier for the content page.
*             - title: The title or heading of the content page.
*             - slug: URL-friendly version of the title used for routing.
*             - content: The main content of the page, typically in HTML or Markdown format.
*             - lastModified: Timestamp indicating the last time the page was updated.
*             - author: The name or identifier of the person who last edited the page.
*             - metaTags: SEO-related meta tags associated with the page.
*             - isPublished: Indicates whether the page is live and accessible to users or in a draft state.
* 
*     PromotionalBanner:
*         Represents the data structure of a promotional banner.
*         Properties:
*             - bannerId: Unique identifier for the promotional banner.
*             - title: A short title or headline for the banner.
*             - imageUrl: URL of the banner image.
*             - linkUrl: URL to which the banner redirects when clicked.
*             - displayDuration: Duration (in seconds) for which the banner should be displayed to the user.
*             - startDate: Date and time when the banner starts being displayed.
*             - endDate: Date and time when the banner stops being displayed.
*             - position: The position on the webpage where the banner should be displayed.
*             - isActive: Indicates whether the banner is currently active and being displayed to users.
* 
*     BannerRequest:
*         Represents the data structure for creating a new promotional banner.
*         Properties:
*             - title: A short title or headline for the banner.
*             - imageUrl: URL of the banner image.
*             - linkUrl: URL to which the banner redirects when clicked.
*             - displayDuration: Duration (in seconds) for which the banner should be displayed to the user.
*             - startDate: Date and time when the banner starts being displayed.
*             - endDate: Date and time when the banner stops being displayed.
*             - position: The position on the webpage where the banner should be displayed.
*             - isActive: Indicates whether the banner should start as active and be displayed to users.
* 
* Dependencies:
*     - ContentService: Handles CRUD operations related to content pages and promotional banners.
*     - LoggerService: Logs events, warnings, and errors.
* 
* Note:
*     Content is a fundamental aspect of the user experience on the platform. Ensuring accurate, up-to-date, 
*     and engaging content not only provides value to the users but also can drive user engagement and sales. 
*     Proper validation and review processes should be in place to ensure the quality of the content.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminContentController : ControllerBase
    {
        DECLARE ContentService contentService
        DECLARE LoggerService logger

        CONSTRUCTOR(ContentService cService, LoggerService logService)
        {
            INIT contentService with cService
            INIT logger with logService
        }

        // GET /api/admin/content/pages
        FUNCTION GetContentPages() RETURNS IActionResult
        {
            TRY
            {
                List<ContentPage> contentPages = CALL contentService.GetContentPages()

                RETURN Ok with contentPages
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching content pages: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // GET /api/admin/content/banners
        FUNCTION GetPromotionalBanners() RETURNS IActionResult
        {
            TRY
            {
                List<PromotionalBanner> banners = CALL contentService.GetPromotionalBanners()

                RETURN Ok with banners
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching promotional banners: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/admin/content/banners
        FUNCTION CreatePromotionalBanner(BannerRequest bannerData) RETURNS IActionResult
        {
            TRY
            {
                PromotionalBanner newBanner = CALL contentService.CreatePromotionalBanner(bannerData)

                RETURN StatusCode 201 with newBanner
            }
            CATCH any exception as error
            {
                LOG error "Error while creating promotional banner: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class ContentPage
    {
        DECLARE int64 pageId
        DECLARE string title
        DECLARE string slug
        DECLARE string content
        DECLARE DateTime lastModified
        DECLARE string author
        DECLARE List<string> metaTags
        DECLARE boolean isPublished
    }

    DEFINE class PromotionalBanner
    {
        DECLARE int64 bannerId
        DECLARE string title
        DECLARE string imageUrl
        DECLARE string linkUrl
        DECLARE int32 displayDuration
        DECLARE DateTime startDate
        DECLARE DateTime endDate
        DECLARE string position
        DECLARE boolean isActive
    }

    DEFINE class BannerRequest
    {
        DECLARE string title
        DECLARE string imageUrl
        DECLARE string linkUrl
        DECLARE int32 displayDuration
        DECLARE DateTime startDate
        DECLARE DateTime endDate
        DECLARE string position
        DECLARE boolean isActive
    }
}
