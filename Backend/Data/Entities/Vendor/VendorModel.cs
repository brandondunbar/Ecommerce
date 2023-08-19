/*
* VendorModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Vendor entity within the E-Commerce application. It captures details about vendors, including business information, policies, and related records.
* 
* Class Definitions:
*     - VendorModel: Represents a vendor with details such as business name, tax ID, policies, and associated products.
*       - Properties:
*         - vendor_id: The primary key identifier for the vendor.
*         - user_id: Foreign key linking to the associated user in the Users table.
*         - business_name: The registered business name of the vendor.
*         - tax_id: The tax identification number of the vendor.
*         - business_email: Business contact email for the vendor.
*         - business_phone: Business contact phone number for the vendor.
*         - shipping_policy: The vendor's policy regarding shipping of products.
*         - return_policy: The vendor's policy regarding the return of products.
*         - status: Status of the vendor, represented as an enumeration (e.g., 'Pending', 'Verified', 'Suspended').
*         - average_rating: Average rating or performance score for the vendor.
*         - created_at: Timestamp indicating when the vendor was registered on the platform.
*         - updated_at: Timestamp indicating the last update to the vendor's details.
*         - verification_date: Date when the vendor was verified.
*         - verified_by: ID or name of the user/system that verified the vendor.
* 
*       - Relationships:
*         - user: Navigation property to retrieve details of the user associated with the vendor.
*         - products: Navigation property to retrieve the list of products associated with the vendor.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class VendorModel
    {
        DECLARE int vendor_id
        DECLARE int user_id
        DECLARE string business_name
        DECLARE string tax_id
        DECLARE string business_email
        DECLARE string business_phone
        DECLARE string shipping_policy
        DECLARE string return_policy
        DECLARE Enum status
        DECLARE decimal(3, 2) average_rating
        DECLARE timestamp created_at
        DECLARE timestamp updated_at
        DECLARE date verification_date, OPTIONAL
        DECLARE string verified_by, OPTIONAL

        // Relationships for fetching details related to the vendor
        DECLARE User user  // Relationship to the User model
        DECLARE List<ProductModel> products  // List of products associated with the vendor
    }
}
