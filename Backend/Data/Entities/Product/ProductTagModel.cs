/*
* ProductTagModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the ProductTag entity within the E-Commerce application.
*     It manages the many-to-many relationship between products and tags.
* 
* Class Definitions:
*     - ProductTagModel: Represents an association between products and tags.
*       - Properties:
*         - product_tag_id: The primary key identifier for the product-tag relationship.
*         - product_id: Foreign key linking to the associated product.
*         - tag_id: Foreign key linking to the associated tag.
*         - assigned_by: Optional foreign key linking to the user who assigned the tag.
*         - assigned_date: Date and time when the tag was assigned to the product.
*         - removed_date: Optional date and time when the tag was removed from the product.
*         - is_active: Boolean flag indicating if the tag is currently active for the product.
* 
*       - Relationships:
*         - product: Navigation property to retrieve details of the product associated with the tag.
*         - tag: Navigation property to retrieve details of the tag associated with the product.
*         - user: Navigation property to retrieve details of the user who assigned the tag (if applicable).
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
        DECLARE int? assigned_by  // This can be null as it's optional
        DECLARE DateTime assigned_date
        DECLARE DateTime? removed_date  // This can be null as it's optional
        DECLARE bool is_active

        // Relationships:

        // 1. Relationship with Product
        DECLARE ProductModel product

        // 2. Relationship with Tag
        DECLARE TagModel tag

        // 3. Relationship with User
        DECLARE UserModel user
    }
}
