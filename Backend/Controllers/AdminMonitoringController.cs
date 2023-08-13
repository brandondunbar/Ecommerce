/*
* AdminMonitoringController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminMonitoringController class plays a pivotal role 
*     in the system's health management. This controller interfaces with the monitoring services, providing 
*     administrators with the ability to view crucial system metrics. This helps in overseeing the platform's 
*     performance, identifying potential bottlenecks, and ensuring seamless operations. Retrieval of monitoring 
*     data is flexible, allowing filtering based on timestamps and specific metrics.
* 
* Classes:
*     AdminMonitoringController:
*         Methods:
*             - GetSystemMonitoringData(DateTime? startTime, DateTime? endTime, string metric): 
*               Retrieves system monitoring data based on the provided filters, such as time range and specific metrics.
* 
*     MonitoringEntry:
*         Represents a single entry in the system's monitoring data.
*         Properties:
*             - metricId: The unique identifier for the metric entry.
*             - metricName: The name or type of the metric being recorded.
*             - timestamp: The date and time when the metric was recorded.
*             - value: The actual numerical value of the metric.
*             - unit: The unit of measurement for the metric.
*             - metadata: Additional information or context related to the metric, stored as key-value pairs.
* 
* Dependencies:
*     - MonitoringService: Manages the retrieval and potential CRUD operations related to system monitoring data.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while 
*       trying to fetch monitoring data.
* 
* Note:
*     Continuous monitoring of system metrics is crucial for ensuring optimal platform performance. 
*     Regularly reviewing this data helps in early detection of issues, ensuring user satisfaction and 
*     minimizing downtime.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/

IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminMonitoringController : ControllerBase
    {
        DECLARE MonitoringService monitoringService
        DECLARE LoggerService logger

        CONSTRUCTOR(MonitoringService mService, LoggerService logService)
        {
            INIT monitoringService with mService
            INIT logger with logService
        }

        // GET /api/admin/monitoring
        FUNCTION GetSystemMonitoringData(DateTime? startTime, DateTime? endTime, string metric) RETURNS IActionResult
        {
            TRY
            {
                List<MonitoringEntry> monitoringEntries = CALL monitoringService.GetMonitoringData(startTime, endTime, metric)

                RETURN Ok with monitoringEntries
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching monitoring data: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class MonitoringEntry
    {
        DECLARE int64 metricId
        DECLARE string metricName
        DECLARE DateTime timestamp
        DECLARE float value
        DECLARE string unit
        DECLARE Dictionary<string, dynamic> metadata
    }
}
