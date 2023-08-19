/*
* ShippingAddressModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Shipping Address entity within the E-Commerce application. It captures details about the various shipping addresses a user can opt for during checkout or other transactions.
* 
* Class Definitions:
*     - ShippingAddressModel: Represents a shipping address entity detailing the recipient's name, address details, geographic coordinates, verification status, and related attributes.
*       - Properties:
*         - address_id: The primary key identifier for the shipping address.
*         - user_id: Foreign key linking to the user associated with the shipping address.
*         - recipient_name: Name of the recipient for this shipping address.
*         - street: The street or road name for the address.
*         - address_line_2: Additional address details, such as apartment or suite number.
*         - city: The city or locality for the address.
*         - state: The state or region for the address.
*         - postal_code: The postal or ZIP code for the address.
*         - country: The country name for the address.
*         - country_code: The 3-letter country code for the address.
*         - phone_number: Contact phone number associated with the address.
*         - is_default: A flag indicating if this is the default shipping address for the user.
*         - address_type: The type of the address (e.g., "Home", "Work").
*         - is_verified: Status indicating whether the address has been verified.
*         - latitude: The latitude coordinates of the address.
*         - longitude: The longitude coordinates of the address.
*         - address_notes: Optional notes or special instructions regarding the address.
*         - created_at: Date and time when the address was added.
*         - updated_at: Date and time of the last update to the address details.
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
        DECLARE string address_line_2, OPTIONAL
        DECLARE string city
        DECLARE string state
        DECLARE string postal_code
        DECLARE string country
        DECLARE string country_code
        DECLARE string phone_number
        DECLARE bool is_default
        DECLARE string address_type
        DECLARE bool is_verified
        DECLARE decimal(9,6) latitude
        DECLARE decimal(9,6) longitude
        DECLARE string address_notes, OPTIONAL
        DECLARE DateTime created_at
        DECLARE DateTime updated_at

        // Relationship:
        // 1. Relationship with User
        DECLARE UserModel user
    }
}
