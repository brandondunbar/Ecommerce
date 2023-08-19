/*
* ReviewModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Review entity within the E-Commerce application. It captures user feedback and ratings for products.
* 
* Class Definitions:
*     - ReviewModel: Represents a review entity with details such as rating, title, content, and approval status.
*       - Properties:
*         - review_id: The primary key identifier for the review.
*         - product_id: Foreign key linking to the associated product.
*         - user_id: Foreign key linking to the user who provided the review.
*         - rating: Rating given by the user (typically on a scale like 1 to 5).
*         - title: The title of the review.
*         - content: Detailed feedback or content of the review.
*         - review_status: Review status (e.g., 'Pending', 'Approved', 'Rejected').
*         - helpful_count: Count of times the review was marked as helpful.
*         - not_helpful_count: Count of times the review was marked as not helpful.
*         - vendor_reply: Reply from the vendor or admin to the review.
*         - is_visible: Flag indicating if the review is visible to others.
*         - created_at: Date and time when the review was created.
*         - updated_at: Date and time when the review was last updated.
* 
*       - Relationships:
*         - product: Navigation property to retrieve details of the product associated with the review.
*         - user: Navigation property to retrieve details of the user who provided the review.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class ReviewModel
    {
        DECLARE int review_id
        DECLARE int product_id
        DECLARE int user_id
        DECLARE int rating
        DECLARE string title
        DECLARE string content
        DECLARE Enum review_status with values ('Pending', 'Approved', 'Rejected')
        DECLARE int helpful_count
        DECLARE int not_helpful_count
        DECLARE string vendor_reply
        DECLARE bool is_visible
        DECLARE DateTime created_at
        DECLARE DateTime updated_at

        // Relationships:

        // 1. Relationship with Product
        DECLARE ProductModel product

        // 2. Relationship with User
        DECLARE UserModel user
    }
}
