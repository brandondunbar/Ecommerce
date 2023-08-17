/*
* ProductTagModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the ProductTag entity within the E-Commerce application.
* 
* Class Definitions:
*     - ProductTagModel: Represents a many-to-many relationship between products and tags, allowing products to be categorized or labeled with multiple tags.
*       - Properties:
*         - product_tag_id: The primary key identifier for the product tag relationship.
*         - product_id: Foreign key linking to the associated product.
*         - tag_id: Foreign key linking to the associated tag.
*         - assigned_date: Date and time when the tag was assigned to the product.
* 
*       - Relationships:
*         - product: Navigation property to retrieve details of the product associated with the tag.
*         - tag: Navigation property to retrieve details of the tag associated with the product.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/


NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class ProductTagModel
    {
        DECLARE int product_tag_id
        DECLARE int product_id
        DECLARE int tag_id
        DECLARE DateTime assigned_date

        // Relationships:

        // 1. Relationship with Product
        DECLARE ProductModel product

        // 2. Relationship with Tag
        DECLARE TagModel tag
    }
}
