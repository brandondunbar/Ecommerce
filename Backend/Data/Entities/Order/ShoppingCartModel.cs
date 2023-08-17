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
*         - user_id: Foreign key linking to the associated user in the Users table.
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
        DECLARE property int user_id, marked as ForeignKey linking to Users table

        // Properties for the shopping cart details
        DECLARE property DateTime created_at
        DECLARE property DateTime updated_at

        // Relationships
        DECLARE NavigationProperty User user         // Link to the user owning the cart
        DECLARE List<NavigationProperty> CartItems cartItems   // Link to the items within the cart
    }
}
