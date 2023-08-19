/*
* ReturnRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Return entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - ReturnRepository: A repository class that encapsulates the data access layer for the Return entity.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddReturn: Adds a new return record to the database.
*         - GetAllReturns: Retrieves all return records from the database.
*         - GetReturnById: Fetches a specific return record by its ID.
*         - GetReturnsByOrderId: Retrieves all returns associated with a specific order ID.
*         - GetReturnsByUserId: Fetches all returns associated with a specific user ID.
*         - UpdateReturnDetails: Updates the details (status and notes) of a specific return record.
*         - DeleteReturn: Removes a specified return record from the database based on its ID.
* 
*       - Relationships:
*         - ReturnModel: Uses the ReturnModel to interact with the Return entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/


NAMESPACE ECommerceApp.Data.Repositories.Return
{
    DEFINE class ReturnRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(ReturnRepository(DbContext context))
        {
            _context = context
        }

        // Add a new return
        FUNCTION AddReturn(ReturnModel returnItem)
        {
            _context.Returns.Add(returnItem)
            _context.SaveChanges()
        }

        // Retrieve all returns
        FUNCTION List<ReturnModel> GetAllReturns()
        {
            RETURN _context.Returns.ToList()
        }

        // Retrieve a return by its ID
        FUNCTION ReturnModel GetReturnById(int returnId)
        {
            RETURN _context.Returns.FirstOrDefault(returnItem => returnItem.ReturnId == returnId)
        }

        // Retrieve returns for a specific order
        FUNCTION List<ReturnModel> GetReturnsByOrderId(int orderId)
        {
            RETURN _context.Returns.Where(returnItem => returnItem.OrderId == orderId).ToList()
        }

        // Retrieve returns for a specific user
        FUNCTION List<ReturnModel> GetReturnsByUserId(int userId)
        {
            RETURN _context.Returns.Where(returnItem => returnItem.UserId == userId).ToList()
        }

        // Update return details (e.g., status or notes)
        FUNCTION UpdateReturnDetails(int returnId, string newStatus, string newNotes)
        {
            DECLARE returnToUpdate = _context.Returns.FirstOrDefault(returnItem => returnItem.ReturnId == returnId)
            IF (returnToUpdate IS NOT NULL)
            {
                returnToUpdate.Status = newStatus
                returnToUpdate.Notes = newNotes
                _context.SaveChanges()
            }
        }

        // Delete a return by its ID
        FUNCTION DeleteReturn(int returnId)
        {
            DECLARE returnToDelete = _context.Returns.FirstOrDefault(returnItem => returnItem.ReturnId == returnId)
            IF (returnToDelete IS NOT NULL)
            {
                _context.Returns.Remove(returnToDelete)
                _context.SaveChanges()
            }
        }
    }
}
