/*
* TagModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Tag entity within the E-Commerce application. Tags are useful metadata that can be associated with products for better categorization and search functionality.
* 
* Class Definitions:
*     - TagModel: Represents a tag entity with details such as name and description.
*       - Properties:
*         - tag_id: The primary key identifier for the tag.
*         - name: The name or label of the tag.
*         - description: A brief description or detail about the tag.
*         - created_at: Date and time when the tag was created.
*         - updated_at: Date and time when the tag was last updated.
* 
*       - Relationships:
*         - productTags: Navigation property to retrieve a list of `ProductTagModel` entities, representing products associated with this tag.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class TagModel
    {
        DECLARE int tag_id
        DECLARE string name
        DECLARE string description
        DECLARE DateTime created_at
        DECLARE DateTime updated_at

        // Relationships:
        // 1. Relationship with ProductTag (to get products associated with a tag)
        DECLARE List<ProductTagModel> productTags
    }
}
