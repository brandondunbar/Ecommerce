/*
* EventLogRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the EventLog entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - EventLogRepository: A repository class that encapsulates the data access layer for the EventLog entity.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddEventLog: Adds a new event log record to the database.
*         - GetAllEventLogs: Retrieves all event logs from the database.
*         - GetEventLogsByType: Fetches event logs based on a specified event type.
*         - GetEventLogsByUserId: Retrieves event logs associated with a specific user ID.
*         - GetEventLogsByDateRange: Fetches event logs that fall within a specified date range.
*         - DeleteEventLog: Removes a specified event log record from the database based on its ID.
* 
*       - Relationships:
*         - EventLogModel: Uses the EventLogModel to interact with the EventLog entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories.EventLog
{
    DEFINE class EventLogRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(EventLogRepository(DbContext context))
        {
            _context = context
        }

        // Add a new event log
        FUNCTION AddEventLog(EventLogModel eventLog)
        {
            _context.EventLogs.Add(eventLog)
            _context.SaveChanges()
        }

        // Retrieve all event logs
        FUNCTION List<EventLogModel> GetAllEventLogs()
        {
            RETURN _context.EventLogs.ToList()
        }

        // Retrieve event logs by type
        FUNCTION List<EventLogModel> GetEventLogsByType(string eventType)
        {
            RETURN _context.EventLogs.Where(log => log.EventType == eventType).ToList()
        }

        // Retrieve event logs by user ID
        FUNCTION List<EventLogModel> GetEventLogsByUserId(int userId)
        {
            RETURN _context.EventLogs.Where(log => log.UserId == userId).ToList()
        }

        // Retrieve event logs within a date range
        FUNCTION List<EventLogModel> GetEventLogsByDateRange(DateTime startDate, DateTime endDate)
        {
            RETURN _context.EventLogs.Where(log => log.EventDate >= startDate AND log.EventDate <= endDate).ToList()
        }

        // Delete an event log by its ID
        FUNCTION DeleteEventLog(int logId)
        {
            DECLARE logToDelete = _context.EventLogs.FirstOrDefault(log => log.LogId == logId)
            IF (logToDelete IS NOT NULL)
            {
                _context.EventLogs.Remove(logToDelete)
                _context.SaveChanges()
            }
        }
    }
}
