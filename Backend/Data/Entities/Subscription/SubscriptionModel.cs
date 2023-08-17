/*
* SubscriptionModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Subscription entity within the E-Commerce application. It captures details about the various subscriptions a user can have for products or services.
* 
* Class Definitions:
*     - SubscriptionModel: Represents a subscription entity with details such as start date, billing cycle, price, and more.
*       - Properties:
*         - subscription_id: The primary key identifier for the subscription.
*         - user_id: Foreign key linking to the user associated with the subscription.
*         - product_id: Optional foreign key linking to the product associated with the subscription.
*         - start_date: The date the subscription starts.
*         - end_date: Optional date indicating when the subscription ends.
*         - billing_cycle: An enumeration representing the billing cycle (e.g., 'Monthly', 'Annually').
*         - status: An enumeration representing the status of the subscription (e.g., 'Active', 'Cancelled').
*         - price: The price of the subscription.
*         - currency: The currency in which the subscription price is denominated.
*         - last_billed: Timestamp of the last time the user was billed for the subscription.
*         - next_billing: Timestamp of the next billing cycle.
*         - created_at: Timestamp indicating when the subscription was created.
*         - updated_at: Timestamp indicating the last update to the subscription.
* 
*       - Relationships:
*         - user: Navigation property to retrieve details of the user associated with the subscription.
*         - product: Optional navigation property to retrieve details of the product associated with the subscription.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class SubscriptionModel
    {
        DECLARE int subscription_id
        DECLARE int user_id
        DECLARE int product_id, OPTIONAL
        DECLARE date start_date
        DECLARE date end_date, OPTIONAL
        DECLARE Enum billing_cycle
        DECLARE Enum status
        DECLARE decimal(10, 2) price
        DECLARE string currency
        DECLARE timestamp last_billed
        DECLARE timestamp next_billing
        DECLARE timestamp created_at
        DECLARE timestamp updated_at

        // Relationships for fetching details about the user and product associated with the subscription
        DECLARE UserModel user
        DECLARE ProductModel product
    }
}
