/*
* SubscriptionModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Subscription entity within the E-Commerce application. It captures details about the various subscriptions a user can have for products or services.
* 
* Class Definitions:
*     - SubscriptionModel: Represents a subscription entity detailing start and end dates, billing details, status, associated product, and other relevant attributes.
*       - Properties:
*         - subscription_id: The primary key identifier for the subscription.
*         - user_id: Foreign key linking to the user associated with the subscription.
*         - product_id: Foreign key linking to the product associated with the subscription.
*         - payment_method_id: Foreign key linking to the payment method used for the subscription.
*         - start_date: The date the subscription starts.
*         - end_date: Optional date indicating when the subscription ends.
*         - billing_cycle: An enumeration representing the billing frequency.
*         - status: An enumeration representing the status of the subscription.
*         - price: The price of the subscription.
*         - currency: The currency in which the subscription price is denominated.
*         - last_billed: Timestamp of the last time the user was billed.
*         - next_billing: Timestamp of the next billing event.
*         - tier_or_level: The level or tier of the subscription.
*         - discount_code: Optional discount code used for the subscription.
*         - auto_renewal: Flag indicating if the subscription will auto-renew.
*         - cancellation_reason: Optional reason provided by the user for cancellation.
*         - created_at: Timestamp indicating when the subscription was created.
*         - updated_at: Timestamp indicating the last update to the subscription.
* 
*       - Relationships:
*         - user: Navigation property to retrieve details of the user associated with the subscription.
*         - product: Navigation property to retrieve details of the product tied to the subscription.
*         - paymentMethod: Navigation property to retrieve details of the payment method used for the subscription.
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
        DECLARE int product_id
        DECLARE int payment_method_id
        DECLARE date start_date
        DECLARE date end_date, OPTIONAL
        DECLARE BillingCycle billing_cycle  // Enum with values like 'Monthly', 'Annually'
        DECLARE SubscriptionStatus status   // Enum with values like 'Active', 'Paused', 'Cancelled', 'Expired'
        DECLARE decimal(10, 2) price
        DECLARE string currency
        DECLARE timestamp last_billed
        DECLARE timestamp next_billing
        DECLARE string tier_or_level
        DECLARE string discount_code, OPTIONAL
        DECLARE bool auto_renewal
        DECLARE string cancellation_reason, OPTIONAL
        DECLARE timestamp created_at
        DECLARE timestamp updated_at

        // Relationships:
        // 1. Relationship with User
        DECLARE UserModel user
        
        // 2. Relationship with Product
        DECLARE ProductModel product
        
        // 3. Relationship with PaymentMethod
        DECLARE PaymentMethodsModel paymentMethod
    }
}
