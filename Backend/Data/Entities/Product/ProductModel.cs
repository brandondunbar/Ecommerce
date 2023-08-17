/*
* ProductModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Product entity within the E-Commerce application.
* 
* Class Definitions:
*     - ProductModel: Represents a product entity with comprehensive details such as name, price, stock quantity, and more.
*       - Properties:
*         - product_id: The primary key identifier for the product.
*         - category_id: Foreign key linking to the associated category.
*         - vendor_id: Foreign key linking to the associated vendor.
*         - name: The name or label of the product.
*         - description: Detailed description of the product.
*         - price: Selling price of the product.
*         - stock_quantity: Quantity of the product available in stock.
*         - is_available: Flag indicating if the product is available for purchase.
*         - image_url: URL pointing to the product image.
*         - sku: Stock Keeping Unit for the product.
*         - created_at: Date and time when the product was added.
*         - updated_at: Date and time of the last update to the product.
*         - manufacturer: Manufacturer of the product.
*         - weight: Weight of the product.
*         - dimensions: Dimensions of the product (e.g., "10x5x3" inches).
*         - rating: Average customer rating for the product.
* 
*       - Relationships:
*         - category: Navigation property to retrieve details of the category associated with the product.
*         - vendor: Navigation property to retrieve details of the vendor associated with the product.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class ProductModel
    {
        DECLARE int product_id
        DECLARE int category_id
        DECLARE int vendor_id
        DECLARE string name
        DECLARE string description
        DECLARE decimal(10, 2) price
        DECLARE int stock_quantity
        DECLARE bool is_available
        DECLARE string image_url
        DECLARE string sku
        DECLARE DateTime created_at
        DECLARE DateTime updated_at
        DECLARE string manufacturer
        DECLARE decimal(7, 2) weight
        DECLARE string dimensions
        DECLARE decimal(3, 2) rating

        // Relationships:

        // 1. Relationship with Category
        DECLARE CategoryModel category

        // 2. Relationship with Vendor
        DECLARE VendorModel vendor
    }
}
