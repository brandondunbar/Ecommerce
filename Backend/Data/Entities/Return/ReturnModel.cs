/*
* ReturnModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Return entity within the E-Commerce application. It captures details about product returns initiated by users after making a purchase.
* 
* Class Definitions:
*     - ReturnModel: Represents a return entity with details such as the reason for the return, status, return date, and resolution date.
*       - Properties:
*         - return_id: The primary key identifier for the return.
*         - order_id: Foreign key linking to the associated order.
*         - user_id: Foreign key linking to the user initiating the return.
*         - product_id: Foreign key linking to the product being returned.
*         - reason: Reason specified by the user for the return.
*         - status: Status of the return, represented as an enumeration (e.g., 'Pending', 'Accepted', 'Rejected').
*         - return_date: Date and time when the return was initiated.
*         - resolution_date: Date and time when the return was resolved (accepted or rejected).
*         - notes: Any additional notes or details about the return.
* 
*       - Relationships:
*         - order: Navigation property to retrieve details of the order associated with the return.
*         - user: Navigation property to retrieve details of the user initiating the return.
*         - product: Navigation property to retrieve details of the product being returned.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/


NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class ReturnModel
    {
        DECLARE int return_id
        DECLARE int order_id
        DECLARE int user_id
        DECLARE int product_id
        DECLARE string reason
        DECLARE ReturnStatus status   // Enum with values like 'Pending', 'Accepted', 'Rejected', etc.
        DECLARE DateTime return_date
        DECLARE DateTime resolution_date
        DECLARE string notes

        // Relationships:
        // 1. Relationship with Order (to fetch details about the order related to the return)
        DECLARE OrderModel order
        
        // 2. Relationship with User (to fetch details about the user initiating the return)
        DECLARE UserModel user

        // 3. Relationship with Product (to fetch details about the product being returned)
        DECLARE ProductModel product
    }
}
