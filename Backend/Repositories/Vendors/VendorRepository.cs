/*
* VendorRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Vendor entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - VendorRepository: A repository class that encapsulates the data access layer for Vendors.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddVendor: Adds a new vendor to the database.
*         - GetAllVendors: Retrieves all vendors from the database.
*         - GetVendorById: Fetches a specific vendor by its ID.
*         - UpdateVendor: Updates the details of a specific vendor.
*         - DeleteVendor: Removes a specific vendor from the database.
*         - GetVendorsByStatus: Retrieves vendors based on their status.
*         - VerifyVendor: Marks a vendor as verified and logs verification details.
*         - SuspendVendor: Suspends a vendor's operations.
* 
*       - Relationships:
*         - Uses VendorModel to interact with the Vendor entity in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories.Vendor
{
    DEFINE class VendorRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(VendorRepository(DbContext context))
        {
            _context = context
        }

        // VENDOR METHODS:

        // Add a new vendor
        FUNCTION AddVendor(VendorModel vendor)
        {
            _context.Vendors.Add(vendor)
            _context.SaveChanges()
        }

        // Retrieve all vendors
        FUNCTION List<VendorModel> GetAllVendors()
        {
            RETURN _context.Vendors.ToList()
        }

        // Retrieve a vendor by their ID
        FUNCTION VendorModel GetVendorById(int vendorId)
        {
            RETURN _context.Vendors.FirstOrDefault(vendor => vendor.VendorId == vendorId)
        }

        // Update vendor details
        FUNCTION UpdateVendor(VendorModel updatedVendor)
        {
            _context.Update(updatedVendor)
            _context.SaveChanges()
        }

        // Delete a vendor by their ID
        FUNCTION DeleteVendor(int vendorId)
        {
            DECLARE vendorToDelete = _context.Vendors.FirstOrDefault(vendor => vendor.VendorId == vendorId)
            IF (vendorToDelete IS NOT NULL)
            {
                _context.Vendors.Remove(vendorToDelete)
                _context.SaveChanges()
            }
        }

        // Retrieve vendors by status
        FUNCTION List<VendorModel> GetVendorsByStatus(Enum vendorStatus)
        {
            RETURN _context.Vendors.Where(vendor => vendor.Status == vendorStatus).ToList()
        }

        // Verify a vendor
        FUNCTION VerifyVendor(int vendorId, string verifier)
        {
            DECLARE vendorToVerify = GetVendorById(vendorId)
            IF (vendorToVerify IS NOT NULL)
            {
                vendorToVerify.Status = 'Verified'
                vendorToVerify.VerificationDate = CurrentDate()
                vendorToVerify.VerifiedBy = verifier
                _context.SaveChanges()
            }
        }

        // Suspend a vendor
        FUNCTION SuspendVendor(int vendorId)
        {
            DECLARE vendorToSuspend = GetVendorById(vendorId)
            IF (vendorToSuspend IS NOT NULL)
            {
                vendorToSuspend.Status = 'Suspended'
                _context.SaveChanges()
            }
        }
    }
}
