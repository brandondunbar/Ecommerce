/*
* CategoryModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Category entity within the E-Commerce application.
* 
* Class Definitions:
*     - CategoryModel: Represents a product category within the e-commerce platform, potentially having hierarchical relationships.
*       - Properties:
*         - category_id: The primary key identifier for the category.
*         - parent_id: Optional foreign key linking to the parent category in a hierarchical setup.
*         - name: The name or label of the category.
*         - description: Brief description of the category.
*         - image_url: URL pointing to the image representation of the category.
*         - display_order: The order in which the category should be displayed relative to other categories.
*         - created_at: Date and time when the category was created.
*         - updated_at: Date and time when the category was last updated.
* 
*       - Relationships:
*         - parentCategory: Self-referencing navigation property pointing to the parent category, if it exists.
*         - subCategories: List of categories that are sub-categories or children of the current category.
*         - products: List of products associated with the category.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/


NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class CategoryModel
    {
        DECLARE int category_id
        DECLARE int? parent_id  // This can be null, as top-level categories won't have a parent
        DECLARE string name
        DECLARE string description
        DECLARE string image_url
        DECLARE int display_order
        DECLARE DateTime created_at
        DECLARE DateTime updated_at

        // Relationships:

        // 1. Self-referencing relationship for parent and child categories
        DECLARE CategoryModel parentCategory
        DECLARE List<CategoryModel> subCategories

        // 2. Relationship with products (if each product belongs to a category)
        DECLARE List<ProductModel> products
    }
}
