/*
* InventoryLogRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the InventoryLog entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - InventoryLogRepository: A repository class that encapsulates the data access layer for the InventoryLog entity.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddInventoryLog: Adds a new inventory log record to the database.
*         - GetAllInventoryLogs: Retrieves all inventory logs from the database.
*         - GetInventoryLogsByProductId: Fetches inventory logs associated with a specific product ID.
*         - GetInventoryLogsByType: Retrieves inventory logs based on a specified type (e.g., 'Addition', 'Subtraction').
*         - GetInventoryLogsByDateRange: Fetches inventory logs that fall within a specified date range.
*         - DeleteInventoryLog: Removes a specified inventory log record from the database based on its ID.
* 
*       - Relationships:
*         - InventoryLogModel: Uses the InventoryLogModel to interact with the InventoryLog entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/


NAMESPACE ECommerceApp.Data.Repositories.InventoryLog
{
    DEFINE class InventoryLogRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(InventoryLogRepository(DbContext context))
        {
            _context = context
        }

        // Add a new inventory log
        FUNCTION AddInventoryLog(InventoryLogModel inventoryLog)
        {
            _context.InventoryLogs.Add(inventoryLog)
            _context.SaveChanges()
        }

        // Retrieve all inventory logs
        FUNCTION List<InventoryLogModel> GetAllInventoryLogs()
        {
            RETURN _context.InventoryLogs.ToList()
        }

        // Retrieve inventory logs for a specific product
        FUNCTION List<InventoryLogModel> GetInventoryLogsByProductId(int productId)
        {
            RETURN _context.InventoryLogs.Where(log => log.ProductId == productId).ToList()
        }

        // Retrieve inventory logs by type (e.g., 'Addition', 'Subtraction')
        FUNCTION List<InventoryLogModel> GetInventoryLogsByType(string logType)
        {
            RETURN _context.InventoryLogs.Where(log => log.LogType == logType).ToList()
        }

        // Retrieve inventory logs within a date range
        FUNCTION List<InventoryLogModel> GetInventoryLogsByDateRange(DateTime startDate, DateTime endDate)
        {
            RETURN _context.InventoryLogs.Where(log => log.LogDate >= startDate AND log.LogDate <= endDate).ToList()
        }

        // Delete an inventory log by its ID
        FUNCTION DeleteInventoryLog(int logId)
        {
            DECLARE logToDelete = _context.InventoryLogs.FirstOrDefault(log => log.LogId == logId)
            IF (logToDelete IS NOT NULL)
            {
                _context.InventoryLogs.Remove(logToDelete)
                _context.SaveChanges()
            }
        }
    }
}
