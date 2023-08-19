/*
* CartItemModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Cart Item entity within the E-Commerce application.
* 
* Class Definitions:
*     - CartItemModel: Represents an item within a user's shopping cart, detailing the product, its quantity, and its price.
*       - Properties:
*         - cart_item_id: The primary key identifier for the cart item.
*         - cart_id: Foreign key linking to the associated shopping cart in the ShoppingCart table.
*         - product_id: Foreign key linking to the associated product in the Products table.
*         - quantity: Number of units of the product in the cart.
*         - price_at_addition: The price of the product when it was added to the cart.
*         - discount_amount: The discount amount, if any, applied to this cart item.
*         - added_at: Date and time marking when the item was added to the cart.
*         - updated_at: Date and time marking the last update to the cart item.
* 
*       - Relationships:
*         - ShoppingCart: Navigation property to fetch details of the shopping cart this item is part of.
*         - Product: Navigation property to retrieve details of the product contained in this cart item.
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
    DEFINE class CartItemModel
    {
        DECLARE property int cart_item_id, marked as PrimaryKey
        DECLARE property int cart_id, marked as ForeignKey linking to ShoppingCart table
        DECLARE property int product_id, marked as ForeignKey linking to Products table

        // Properties for the cart item details
        DECLARE property int quantity
        DECLARE property decimal price_at_addition with precision 10, scale 2
        DECLARE property decimal discount_amount with precision 7, scale 2
        DECLARE property DateTime added_at
        DECLARE property DateTime updated_at

        // Relationships
        DECLARE NavigationProperty ShoppingCart cart  // Link to the shopping cart this item belongs to
        DECLARE NavigationProperty Product product   // Link to the product in this cart item
    }
}
