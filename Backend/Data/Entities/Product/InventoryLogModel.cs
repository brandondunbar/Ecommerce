/*
* InventoryLogModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Inventory Log entity within the E-Commerce application.
*     It tracks changes in product inventory over time.
* 
* Class Definitions:
*     - InventoryLogModel: Represents a log entry detailing changes in the inventory of a product.
*       - Properties:
*         - log_id: The primary key identifier for the inventory log entry.
*         - product_id: Foreign key linking to the associated product.
*         - previous_quantity: The quantity of the product before the change.
*         - new_quantity: The quantity of the product after the change.
*         - change_reason: Reason for the change in inventory, represented as an enumeration (e.g., 'Sale', 'StockReplenishment', 'Adjustment').
*         - changed_by: The entity or person responsible for the change.
*         - timestamp: Date and time when the inventory change was logged.
* 
*       - Relationships:
*         - product: Navigation property to retrieve details of the product associated with the inventory change.
* 
*     - InvChangeReason: An enumeration representing the reason for a change in product inventory.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/


NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class InventoryLogModel
    {
        DECLARE int log_id
        DECLARE int product_id
        DECLARE int previous_quantity
        DECLARE int new_quantity
        DECLARE Enum InvChangeReason change_reason
        DECLARE string changed_by
        DECLARE DateTime timestamp

        // Relationships:
        // 1. Relationship with Products
        DECLARE ProductModel product
    }
}

DEFINE Enum InvChangeReason
{
    Sale,
    StockReplenishment,
    Adjustment
}
