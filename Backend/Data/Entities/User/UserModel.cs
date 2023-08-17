/*
* UserModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the User entity within the E-Commerce application. It captures details about registered users, including personal information, authentication details, and related records.
* 
* Class Definitions:
*     - UserModel: Represents a registered user with details such as username, email, personal information, and more.
*       - Properties:
*         - user_id: The primary key identifier for the user.
*         - username: The unique username chosen by the user during registration.
*         - password_hash: A hashed representation of the user's password.
*         - email: The user's email address.
*         - first_name: The user's first name.
*         - last_name: The user's last name.
*         - date_registered: The date the user registered on the platform.
*         - date_of_birth: The user's date of birth.
*         - phone_number: The user's contact phone number.
*         - profile_image: URL or path to the user's profile image.
*         - is_active: Boolean indicating if the user's account is active.
*         - role: An enumeration representing the user's role (e.g., 'Customer', 'Admin').
*         - last_login: Timestamp indicating the last time the user logged into the platform.
* 
*       - Relationships:
*         - orders: Navigation property to retrieve the list of orders placed by the user.
*         - reviews: Navigation property to retrieve the list of reviews written by the user.
*         - payment_methods: Navigation property to retrieve the list of payment methods saved by the user.
*         - shipping_addresses: Navigation property to retrieve the list of shipping addresses saved by the user.
*         - subscriptions: Navigation property to retrieve the list of active subscriptions associated with the user.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class UserModel
    {
        DECLARE int user_id
        DECLARE string username
        DECLARE string password_hash
        DECLARE string email
        DECLARE string first_name
        DECLARE string last_name
        DECLARE date date_registered
        DECLARE date date_of_birth
        DECLARE string phone_number
        DECLARE string profile_image
        DECLARE bool is_active
        DECLARE Enum role
        DECLARE timestamp last_login

        // Relationships for fetching details related to the user (e.g., orders, reviews, etc.)
        DECLARE List<OrderModel> orders
        DECLARE List<ReviewModel> reviews
        DECLARE List<PaymentMethodsModel> payment_methods
        DECLARE List<ShippingAddressModel> shipping_addresses
        DECLARE List<SubscriptionModel> subscriptions
    }
}
