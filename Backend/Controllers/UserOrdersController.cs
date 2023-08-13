/*
* UserOrdersController.cs
*
* Description:
*     This controller handles operations related to a user's order history within the ECommerceApp.
*     It provides functionalities to view a list of past orders for the authenticated user. The results
*     can be filtered and paginated based on the provided parameters.
* 
* Classes:
*     UserOrdersController:
*         Methods:
*             - GetOrders(int? page, int? limit, string? status): Retrieves the orders for the authenticated user.
* 
*     Order:
*         Represents an individual order placed by a user.
*         Properties:
*             - Id: Unique identifier for the order.
*             - OrderDate: Date and time when the order was placed.
*             - Status: Current status of the order (e.g., "pending", "completed").
*             - Items: List of items/products in the order.
*             - TotalAmount: Total amount of the order.
*             - ShippingAddress: Address where the order is to be shipped.
*             - PaymentMethod: Method used for payment (e.g., "Credit Card", "PayPal").
*             - TrackingNumber: Tracking number for shipped orders.
* 
*     OrderItem:
*         Represents an item or product in an order.
*         Properties:
*             - ProductId: Unique identifier for the product.
*             - ProductName: Name of the product.
*             - Quantity: Quantity of the product ordered.
*             - UnitPrice: Price of the product per unit.
*             - Total: Total price for the item (unitPrice * quantity).
* 
*     Address:
*         Represents a shipping address.
*         Properties:
*             - Street: Street address.
*             - City: City name.
*             - State: State or region.
*             - PostalCode: Postal or ZIP code.
*             - Country: Country name.
* 
* Dependencies:
*     - OrderService: Service for handling operations related to orders.
*     - AuthService: Service for handling authentication and user-related operations.
*     - LoggerService: Service for logging errors and other important events.
* 
* Note:
*     Ensure that the user is authenticated before accessing the functionalities provided by this controller.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class UserOrdersController : ControllerBase
    {
        DECLARE OrderService orderService
        DECLARE AuthService authService
        DECLARE LoggerService logger

        CONSTRUCTOR(OrderService oService, AuthService aService, LoggerService logService)
        {
            INIT orderService with oService
            INIT authService with aService
            INIT logger with logService
        }

        // GET /api/users/orders
        FUNCTION GetOrders(int? page, int? limit, string? status) RETURNS IActionResult
        {
            // Ensure user is authenticated
            IF NOT authService.IsUserAuthenticated()
                RETURN Unauthorized

            TRY
            {
                // Retrieve orders based on optional filters
                List<Order> orders = CALL orderService.GetOrdersForUser(authService.GetCurrentUserId(), page, limit, status)

                IF orders is empty
                    RETURN Ok with message "No orders found for the user"

                RETURN Ok with orders
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving orders: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Order
    {
        DECLARE int Id
        DECLARE DateTime OrderDate
        DECLARE string Status
        DECLARE List<OrderItem> Items
        DECLARE float TotalAmount
        DECLARE Address ShippingAddress
        DECLARE string PaymentMethod
        DECLARE string TrackingNumber
    }

    DEFINE class OrderItem
    {
        DECLARE int ProductId
        DECLARE string ProductName
        DECLARE int Quantity
        DECLARE float UnitPrice
        DECLARE float Total
    }

    DEFINE class Address
    {
        DECLARE string Street
        DECLARE string City
        DECLARE string State
        DECLARE string PostalCode
        DECLARE string Country
    }
}
