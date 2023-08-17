/*
* TransactionModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Transaction entity within the E-Commerce application. It captures details about the financial transactions related to orders.
* 
* Class Definitions:
*     - TransactionModel: Represents a financial transaction with details such as amount, transaction type, payment method, and more.
*       - Properties:
*         - transaction_id: The primary key identifier for the transaction.
*         - order_id: Foreign key linking to the order associated with the transaction.
*         - user_id: Foreign key linking to the user associated with the transaction.
*         - amount: The monetary value of the transaction.
*         - currency: The currency in which the transaction amount is denominated.
*         - transaction_type: An enumeration representing the type of transaction (e.g., 'Purchase', 'Refund').
*         - payment_method: An enumeration representing the method of payment (e.g., 'Credit Card', 'PayPal').
*         - payment_gateway: The gateway through which the payment was processed (e.g., 'Stripe', 'PayPal API').
*         - transaction_status: An enumeration indicating the status of the transaction (e.g., 'Completed', 'Failed').
*         - transaction_date: Timestamp indicating when the transaction took place.
*         - fee: Any fee associated with the transaction, such as a processing fee.
*         - notes: Optional notes or details about the transaction.
* 
*       - Relationships:
*         - order: Navigation property to retrieve details of the order associated with the transaction.
*         - user: Navigation property to retrieve details of the user associated with the transaction.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/

NAMESPACE ECommerceApp.Data.Models
{
    DEFINE class TransactionModel
    {
        DECLARE int transaction_id
        DECLARE int order_id
        DECLARE int user_id
        DECLARE decimal(10, 2) amount
        DECLARE string currency
        DECLARE Enum transaction_type
        DECLARE Enum payment_method
        DECLARE string payment_gateway
        DECLARE Enum transaction_status
        DECLARE timestamp transaction_date
        DECLARE decimal(10, 2) fee
        DECLARE string notes, OPTIONAL

        // Relationships for fetching details about the order and user associated with the transaction
        DECLARE OrderModel order
        DECLARE UserModel user
    }
}
