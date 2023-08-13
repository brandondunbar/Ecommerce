/*
* AdminReportsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminReportsController class handles the generation and 
*     retrieval of various reports for the E-Commerce platform. These reports provide insights into sales performance and 
*     user activity, aiding administrators in making informed business decisions.
* 
* Classes:
*     AdminReportsController:
*         Methods:
*             - GenerateSalesReport(DateTime? startDate, DateTime? endDate, string? granularity): Produces a detailed sales 
*               report within the given date range and granularity.
*             - GenerateUserActivityReport(DateTime? startDate, DateTime? endDate, string? granularity): Produces a report 
*               detailing user activity metrics over a specified period and granularity.
* 
*     SalesReport:
*         Represents a comprehensive sales report, detailing performance metrics, top-selling products, and daily sales breakdowns.
* 
*     ProductSalesData:
*         Represents sales data of individual products, detailing the quantity sold.
* 
*     DailyBreakdownData:
*         Represents daily sales and revenue data.
* 
*     UserActivityReport:
*         Represents a comprehensive user activity report, detailing metrics like total users, average session durations, 
*         and daily logins.
* 
*     PageVisitData:
*         Represents data for the most visited pages.
* 
*     DailyLoginData:
*         Represents daily user login counts.
* 
* Dependencies:
*     - SalesReportService: Manages sales report generation by aggregating sales data.
*     - UserActivityReportService: Manages user activity report generation by aggregating user activity data.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while generating reports.
* 
* Note:
*     Generating accurate and timely reports is crucial for business intelligence and strategic decision-making. 
*     Ensure the data integrity and timeliness of these reports. Any inaccuracies or delays can lead to suboptimal 
*     business decisions.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminReportsController : ControllerBase
    {
        DECLARE SalesReportService salesReportService
        DECLARE UserActivityReportService userActivityReportService
        DECLARE LoggerService logger

        CONSTRUCTOR(SalesReportService sService, UserActivityReportService uService, LoggerService logService)
        {
            INIT salesReportService with sService
            INIT userActivityReportService with uService
            INIT logger with logService
        }

        // GET /api/admin/reports/sales
        FUNCTION GenerateSalesReport(DateTime? startDate, DateTime? endDate, string? granularity) RETURNS IActionResult
        {
            TRY
            {
                SalesReport report = CALL salesReportService.GenerateReport(startDate, endDate, granularity)

                RETURN Ok with report
            }
            CATCH any exception as error
            {
                LOG error "Error while generating sales report: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // GET /api/admin/reports/user-activity
        FUNCTION GenerateUserActivityReport(DateTime? startDate, DateTime? endDate, string? granularity) RETURNS IActionResult
        {
            TRY
            {
                UserActivityReport report = CALL userActivityReportService.GenerateReport(startDate, endDate, granularity)

                RETURN Ok with report
            }
            CATCH any exception as error
            {
                LOG error "Error while generating user activity report: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class SalesReport
    {
        DECLARE DateTime startDate
        DECLARE DateTime endDate
        DECLARE int totalSales
        DECLARE float totalRevenue
        DECLARE float averageOrderValue
        DECLARE List<ProductSalesData> topSellingProducts
        DECLARE List<ProductSalesData> leastSellingProducts
        DECLARE List<DailyBreakdownData> dailyBreakdown
    }

    DEFINE class ProductSalesData
    {
        DECLARE int productId
        DECLARE string productName
        DECLARE int quantitySold
    }

    DEFINE class DailyBreakdownData
    {
        DECLARE DateTime date
        DECLARE int sales
        DECLARE float revenue
    }

    DEFINE class UserActivityReport
    {
        DECLARE DateTime startDate
        DECLARE DateTime endDate
        DECLARE int totalUsers
        DECLARE int activeUsers
        DECLARE float averageSessionDuration
        DECLARE List<PageVisitData> topVisitedPages
        DECLARE List<DailyLoginData> dailyLogins
    }

    DEFINE class PageVisitData
    {
        DECLARE string pageName
        DECLARE int visitCount
    }

    DEFINE class DailyLoginData
    {
        DECLARE DateTime date
        DECLARE int loginCount
    }
}
