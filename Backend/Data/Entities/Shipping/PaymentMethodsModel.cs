/*
* PaymentMethodsModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Payment Methods entity within the E-Commerce application. It captures details about the various payment methods a user can opt for during checkout or other transactions.
* 
* Class Definitions:
*     - PaymentMethodsModel: Represents a payment method entity with details such as the provider, token, payment type, and more.
*       - Properties:
*         - payment_method_id: The primary key identifier for the payment method.
*         - user_id: Foreign key linking to the user owning the payment method.
*         - provider: The provider for the payment method, represented as an enumeration (e.g., 'Stripe', 'PayPal', 'Bank').
*         - token: A secure token associated with the payment method.
*         - payment_type: The type of the payment method, represented as an enumeration (e.g., 'Credit Card', 'Bank Account').
*         - last_four_digits: The last four digits of the card or account number.
*         - expiration_date: Expiration date of the payment method (optional for some methods like bank accounts).
*         - is_default: A boolean indicating if this is the default payment method for the user.
*         - created_at: Date and time when the payment method was added.
*         - updated_at: Date and time of the last update to the payment method details.
* 
*       - Relationships:
*         - user: Navigation property to retrieve details of the user owning the payment method.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class PaymentMethodsModel
    {
        DECLARE int payment_method_id
        DECLARE int user_id
        DECLARE Provider provider  // Enum with values like 'Stripe', 'PayPal', 'Bank'
        DECLARE string token
        DECLARE PaymentType payment_type  // Enum with values like 'Credit Card', 'Bank Account'
        DECLARE string last_four_digits
        DECLARE Date expiration_date, OPTIONAL
        DECLARE bool is_default
        DECLARE DateTime created_at
        DECLARE DateTime updated_at

        // Relationship with User (to fetch details about the user owning the payment method)
        DECLARE UserModel user
    }
}
