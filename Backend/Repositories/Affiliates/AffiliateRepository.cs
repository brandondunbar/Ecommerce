/*
* AffiliateRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Affiliate entities within the E-Commerce application's database.
* 
* Class Definitions:
*     - AffiliateRepository: A repository class that encapsulates the data access layer for the Affiliate entity, extending the base repository functionalities.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - GetByAffiliateCode: Retrieves an affiliate entity by its unique referral code.
*         - GetByUserId: Retrieves all affiliate entities associated with a specific user.
*         - GetAllActiveAffiliates: Retrieves all active affiliates from the database.
*         - IsAffiliateCodeUnique: Checks if a provided affiliate code is unique or already in use.
*         - UpdateAffiliateStatus: Updates the active status of an affiliate.
* 
*       - Relationships:
*         - AffiliateModel: Uses the AffiliateModel to interact with the Affiliate entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/


NAMESPACE ECommerceApp.Data.Repositories.Affiliates
{
    DEFINE class AffiliateRepository : BaseRepository<AffiliateModel>
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(AffiliateRepository(DbContext context)) : base(context)
        {
            _context = context
        }

        // Custom methods specific to the Affiliate model

        // Retrieve an affiliate by their unique affiliate code
        FUNCTION AffiliateModel GetByAffiliateCode(string code)
        {
            RETURN _context.Affiliates.FirstOrDefault(affiliate => affiliate.AffiliateCode == code)
        }

        // Retrieve all affiliates associated with a specific user
        FUNCTION IEnumerable<AffiliateModel> GetByUserId(int userId)
        {
            RETURN _context.Affiliates.Where(affiliate => affiliate.UserId == userId).ToList()
        }

        // Retrieve all active affiliates
        FUNCTION IEnumerable<AffiliateModel> GetAllActiveAffiliates()
        {
            RETURN _context.Affiliates.Where(affiliate => affiliate.IsActive == true).ToList()
        }

        // Check if an affiliate code is already in use
        FUNCTION bool IsAffiliateCodeUnique(string code)
        {
            RETURN !_context.Affiliates.Any(affiliate => affiliate.AffiliateCode == code)
        }

        // Update the status of an affiliate (e.g., activate or deactivate)
        FUNCTION UpdateAffiliateStatus(int affiliateId, bool status)
        {
            DECLARE affiliate = _context.Affiliates.Find(affiliateId)
            IF (affiliate IS NOT NULL)
            {
                affiliate.IsActive = status
                _context.SaveChanges()
            }
        }
    }
}
