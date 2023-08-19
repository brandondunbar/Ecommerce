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
*         - payment_method_id: Foreign key linking to the associated payment method in the PaymentMethods table.
*         - order_date: Date and time when the order was placed.
*         - order_status: Status of the order, represented as an enumeration.
*         - total_price: Total price of the order, excluding taxes and discounts.
*         - tax_amount: The tax applied to the order.
*         - shipping_cost: Cost of shipping for the order.
*         - discount_amount: Discount applied to the order.
*         - payment_status: Status of the payment, represented as an enumeration.
*         - shipping_provider: The provider handling the shipping of the order.
*         - tracking_number: Shipping tracking number, if available.
*         - expected_delivery: Expected delivery date, if provided by the shipper.
*         - notes: Any additional notes or instructions related to the order.
* 
*       - Relationships:
*         - User: Navigation property to retrieve details of the user who placed the order.
*         - ShippingAddress: Navigation property to fetch details of the shipping address associated with the order.
*         - PaymentMethod: Navigation property to fetch details of the payment method used for the order.
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
        DECLARE property int payment_method_id, marked as ForeignKey linking to PaymentMethods table

        // Properties for the order details
        DECLARE property DateTime order_date
        DECLARE property Enum order_status, with values ('Pending', 'Shipped', 'Delivered', 'Cancelled')
        DECLARE property decimal total_price with precision 10, scale 2
        DECLARE property decimal tax_amount with precision 7, scale 2
        DECLARE property decimal shipping_cost with precision 7, scale 2
        DECLARE property decimal discount_amount with precision 7, scale 2
        DECLARE property Enum payment_status, with values ('Paid', 'Pending', 'Refunded')
        DECLARE property string shipping_provider, with max length of 50 characters
        DECLARE property string tracking_number, with max length of 100 characters
        DECLARE property DATE expected_delivery
        DECLARE property string notes, as TEXT

        // Relationships
        DECLARE NavigationProperty User user         // Link to the user who placed the order
        DECLARE NavigationProperty ShippingAddress shipping_address  // Link to the shipping address for the order
        DECLARE NavigationProperty PaymentMethod payment_method     // Link to the payment method used for the order
        DECLARE List<NavigationProperty> OrderItems orderItems   // Link to the items within the order
    }

    DEFINE Enum OrderStatus
    {
        VALUES Pending, Shipped, Delivered, Cancelled
    }

    DEFINE Enum PaymentStatus
    {
        VALUES Paid, Pending, Refunded
    }
}
