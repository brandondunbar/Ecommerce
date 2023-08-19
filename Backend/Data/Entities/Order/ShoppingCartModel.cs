/*
* ShoppingCartModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the ShoppingCart entity within the E-Commerce application.
* 
* Class Definitions:
*     - ShoppingCartModel: Represents a shopping cart entity detailing the products a user intends to purchase.
*       - Properties:
*         - cart_id: The primary key identifier for the shopping cart.
*         - user_id: Foreign key linking to the associated user in the Users table. Nullable since a cart can belong to non-logged-in users.
*         - session_id: Unique session identifier used for non-logged-in users.
*         - status: Status of the cart, represented as an enumeration.
*         - total_price: Total price of items in the cart.
*         - discount_amount: Discount amount applied to the cart.
*         - created_at: Date and time when the shopping cart was created.
*         - updated_at: Date and time when the shopping cart was last updated.
* 
*       - Relationships:
*         - User: Navigation property to retrieve details of the user who owns the cart.
*         - CartItems: Navigation property to list items that are part of the shopping cart.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

IMPORT necessary libraries

NAMESPACE ECommerceApp.Data.Entities
{
    DEFINE class ShoppingCartModel
    {
        DECLARE property int cart_id, marked as PrimaryKey
        DECLARE property int? user_id, marked as ForeignKey linking to Users table // Nullable for non-logged-in users
        DECLARE property string session_id, with max length of 255 characters
        DECLARE property Enum CartStatus status
        DECLARE property decimal total_price with precision 10, scale 2
        DECLARE property decimal discount_amount with precision 7, scale 2
        DECLARE property DateTime created_at
        DECLARE property DateTime updated_at

        // Relationships
        DECLARE NavigationProperty User user  // Link to the user owning the cart, if any
        DECLARE List<NavigationProperty> CartItems cartItems   // Link to the items within the cart
    }

    DEFINE Enum CartStatus
    {
        VALUES Active, Abandoned, ConvertedToOrder
    }
}
