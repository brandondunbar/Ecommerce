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
*         - payment_info: Payment information or details provided by the vendor.
*         - shipping_policy: The vendor's policy regarding shipping of products.
*         - return_policy: The vendor's policy regarding the return of products.
*         - is_verified: Boolean indicating if the vendor has been verified by the platform.
*         - created_at: Timestamp indicating when the vendor was registered on the platform.
*         - updated_at: Timestamp indicating the last update to the vendor's details.
* 
*       - Relationships:
*         - userModel: Navigation property to retrieve details of the user associated with the vendor.
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
        DECLARE string payment_info
        DECLARE string shipping_policy
        DECLARE string return_policy
        DECLARE bool is_verified
        DECLARE timestamp created_at
        DECLARE timestamp updated_at

        // Relationships for fetching details related to the vendor
        DECLARE User userModel  // Relationship to the User model
        DECLARE List<ProductModel> products  // List of products associated with the vendor
    }
}
