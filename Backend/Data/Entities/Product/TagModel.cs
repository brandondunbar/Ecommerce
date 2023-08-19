/*
* TagModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Tag entity within the E-Commerce application. Tags are useful metadata that can be associated with products for better categorization and search functionality.
* 
* Class Definitions:
*     - TagModel: Represents a tag entity with details such as name, description, type, and optional attributes like icon_url and color.
*       - Properties:
*         - tag_id: The primary key identifier for the tag.
*         - name: The name or label of the tag.
*         - description: A brief description or detail about the tag.
*         - type: The type or category of the tag.
*         - icon_url: URL to an icon or image representing the tag.
*         - color: HEX color code representing the tag.
*         - is_active: Flag indicating if the tag is currently in use.
*         - usage_count: Counter indicating the number of times the tag is used.
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
        DECLARE string type
        DECLARE string icon_url
        DECLARE string color
        DECLARE bool is_active
        DECLARE int usage_count
        DECLARE DateTime created_at
        DECLARE DateTime updated_at

        // Relationships:
        // 1. Relationship with ProductTag (to get products associated with a tag)
        DECLARE List<ProductTagModel> productTags
    }
}
