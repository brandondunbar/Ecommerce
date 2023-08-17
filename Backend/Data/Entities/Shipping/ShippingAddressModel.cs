/*
* ShippingAddressModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Shipping Address entity within the E-Commerce application. It captures details about the various shipping addresses a user can opt for during checkout or other transactions.
* 
* Class Definitions:
*     - ShippingAddressModel: Represents a shipping address entity with details such as the recipient's name, street, city, state, and more.
*       - Properties:
*         - address_id: The primary key identifier for the shipping address.
*         - user_id: Foreign key linking to the user associated with the shipping address.
*         - recipient_name: Name of the recipient for this shipping address.
*         - street: The street or road name for the address.
*         - city: The city or locality for the address.
*         - state: The state or region for the address.
*         - postal_code: The postal or ZIP code for the address.
*         - country: The country for the address.
*         - phone_number: Contact phone number associated with the address.
*         - is_default: A boolean indicating if this is the default shipping address for the user.
*         - address_notes: Optional notes or special instructions regarding the address.
* 
*       - Relationships:
*         - user: Navigation property to retrieve details of the user associated with the shipping address.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class ShippingAddressModel
    {
        DECLARE int address_id
        DECLARE int user_id
        DECLARE string recipient_name
        DECLARE string street
        DECLARE string city
        DECLARE string state
        DECLARE string postal_code
        DECLARE string country
        DECLARE string phone_number
        DECLARE bool is_default
        DECLARE string address_notes, OPTIONAL

        // Relationship with User (to fetch details about the user associated with the shipping address)
        DECLARE UserModel user
    }
}
