/*
* PartnershipRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Partnership entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - PartnershipRepository: A repository class that encapsulates the data access layer for the Partnership entity.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddPartnership: Adds a new partnership record to the database.
*         - GetAllPartnerships: Retrieves all partnership records from the database.
*         - GetPartnershipById: Fetches a specific partnership record by its ID.
*         - GetPartnershipsByUserId: Retrieves all partnerships associated with a specific user ID.
*         - UpdatePartnershipDetails: Updates the details (status and notes) of a specific partnership record.
*         - DeletePartnership: Removes a specified partnership record from the database based on its ID.
* 
*       - Relationships:
*         - PartnershipModel: Uses the PartnershipModel to interact with the Partnership entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories.Partnership
{
    DEFINE class PartnershipRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(PartnershipRepository(DbContext context))
        {
            _context = context
        }

        // Add a new partnership
        FUNCTION AddPartnership(PartnershipModel partnership)
        {
            _context.Partnerships.Add(partnership)
            _context.SaveChanges()
        }

        // Retrieve all partnerships
        FUNCTION List<PartnershipModel> GetAllPartnerships()
        {
            RETURN _context.Partnerships.ToList()
        }

        // Retrieve a partnership by its ID
        FUNCTION PartnershipModel GetPartnershipById(int partnershipId)
        {
            RETURN _context.Partnerships.FirstOrDefault(partnership => partnership.PartnershipId == partnershipId)
        }

        // Retrieve partnerships for a specific user
        FUNCTION List<PartnershipModel> GetPartnershipsByUserId(int userId)
        {
            RETURN _context.Partnerships.Where(partnership => partnership.UserId == userId).ToList()
        }

        // Update partnership details (e.g., status or notes)
        FUNCTION UpdatePartnershipDetails(int partnershipId, string newStatus, string newNotes)
        {
            DECLARE partnershipToUpdate = _context.Partnerships.FirstOrDefault(partnership => partnership.PartnershipId == partnershipId)
            IF (partnershipToUpdate IS NOT NULL)
            {
                partnershipToUpdate.Status = newStatus
                partnershipToUpdate.Notes = newNotes
                _context.SaveChanges()
            }
        }

        // Delete a partnership by its ID
        FUNCTION DeletePartnership(int partnershipId)
        {
            DECLARE partnershipToDelete = _context.Partnerships.FirstOrDefault(partnership => partnership.PartnershipId == partnershipId)
            IF (partnershipToDelete IS NOT NULL)
            {
                _context.Partnerships.Remove(partnershipToDelete)
                _context.SaveChanges()
            }
        }
    }
}
