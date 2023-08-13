/*
* AdminLogsController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminLogsController is crucial for the oversight 
*     and troubleshooting processes of the E-Commerce platform. The controller provides an interface for 
*     administrators to view system logs, which capture important events, warnings, and errors. By offering 
*     filtered views based on date ranges, log levels, and specific events, it aids in the rapid identification 
*     and rectification of issues.
* 
* Classes:
*     AdminLogsController:
*         Methods:
*             - GetSystemLogs(DateTime? startDate, DateTime? endDate, string logLevel, string event): 
*               Retrieves system logs based on provided filters, which include date range, log level, and specific events.
* 
*     LogEntry:
*         Represents an entry in the system's logs.
*         Properties:
*             - logId: The unique identifier for the log entry.
*             - timestamp: The date and time when the log entry was created.
*             - logLevel: The severity level of the log (e.g., INFO, WARN, ERROR).
*             - event: A brief description or name of the event that triggered the log.
*             - message: A detailed message associated with the log entry.
*             - metadata: Additional data related to the log entry, stored as key-value pairs.
* 
* Dependencies:
*     - LogsService: Manages CRUD operations related to system logs, and facilitates the retrieval 
*       of logs based on the provided filters.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while 
*       trying to fetch system logs.
* 
* Note:
*     Regular monitoring of system logs is crucial for maintaining the health and security of the platform. 
*     Any anomalies or unexpected events should be investigated promptly. Admins should pay special attention 
*     to logs with higher severity levels, such as ERROR, as they may indicate critical issues.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminLogsController : ControllerBase
    {
        DECLARE LogsService logsService
        DECLARE LoggerService logger

        CONSTRUCTOR(LogsService lService, LoggerService logService)
        {
            INIT logsService with lService
            INIT logger with logService
        }

        // GET /api/admin/logs
        FUNCTION GetSystemLogs(DateTime? startDate, DateTime? endDate, string logLevel, string event) RETURNS IActionResult
        {
            TRY
            {
                List<LogEntry> logEntries = CALL logsService.GetLogs(startDate, endDate, logLevel, event)

                RETURN Ok with logEntries
            }
            CATCH any exception as error
            {
                LOG error "Error while fetching system logs: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class LogEntry
    {
        DECLARE int64 logId
        DECLARE DateTime timestamp
        DECLARE string logLevel
        DECLARE string event
        DECLARE string message
        DECLARE Dictionary<string, dynamic> metadata
    }
}
