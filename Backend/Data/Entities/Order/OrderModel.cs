/*
* OrderModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Order entity within the E-Commerce application.
* 
* Class Definitions:
*     - OrderModel: Represents an order entity detailing the user's purchase, shipping, payment methods, and more.
*       - Properties:
*         - order_id: The primary key identifier for the order.
*         - user_id: Foreign key linking to the associated user in the Users table.
*         - shipping_address_id: Foreign key linking to the associated shipping address in the ShippingAddresses table.
*         - order_date: Date and time when the order was placed.
*         - order_status: Status of the order, represented as an enumeration (e.g., 'Pending', 'Shipped', 'Delivered', 'Cancelled').
*         - total_price: Total price of the order, including any taxes or discounts.
*         - shipping_cost: Cost of shipping for the order.
*         - payment_method: Method used for payment, represented as an enumeration (e.g., 'Credit Card', 'PayPal').
*         - payment_status: Status of the payment, represented as an enumeration (e.g., 'Paid', 'Pending', 'Refunded').
*         - tracking_number: Shipping tracking number, if available.
*         - expected_delivery: Expected delivery date, if provided by the shipper.
*         - notes: Any additional notes or instructions related to the order.
* 
*       - Relationships:
*         - User: Navigation property to retrieve details of the user who placed the order.
*         - ShippingAddress: Navigation property to fetch details of the shipping address associated with the order.
*         - OrderItems: Navigation property to list items that are part of the order.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

IMPORT necessary libraries

NAMESPACE ECommerceApp.Data.Entities
{
    DEFINE class OrderModel
    {
        DECLARE property int order_id, marked as PrimaryKey
        DECLARE property int user_id, marked as ForeignKey linking to Users table
        DECLARE property int shipping_address_id, marked as ForeignKey linking to ShippingAddresses table

        // Properties for the order details
        DECLARE property DateTime order_date
        DECLARE property ENUM order_status, with values ('Pending', 'Shipped', 'Delivered', 'Cancelled')
        DECLARE property DECIMAL(10, 2) total_price
        DECLARE property DECIMAL(7, 2) shipping_cost
        DECLARE property ENUM payment_method, with values ('Credit Card', 'PayPal', etc.)
        DECLARE property ENUM payment_status, with values ('Paid', 'Pending', 'Refunded')
        DECLARE property string tracking_number, with max length of 100 characters
        DECLARE property DATE expected_delivery
        DECLARE property string notes, as TEXT

        // Relationships
        DECLARE NavigationProperty User user         // Link to the user who placed the order
        DECLARE NavigationProperty ShippingAddress shipping_address  // Link to the shipping address for the order
        DECLARE List<NavigationProperty> OrderItems orderItems   // Link to the items within the order
    }
}
