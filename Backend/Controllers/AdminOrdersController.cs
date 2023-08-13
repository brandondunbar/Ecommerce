/*
* AdminOrdersController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, the AdminOrdersController class is responsible for 
*     the management and oversight of orders placed on the E-Commerce platform. Given the critical nature 
*     of orders to an e-commerce business, this controller provides functionalities for administrators to 
*     view and manage orders, ensuring timely and accurate processing and delivery.
* 
* Classes:
*     AdminOrdersController:
*         Methods:
*             - ListOrders(string? status, DateTime? fromDate, DateTime? toDate): 
*               Retrieves a list of orders based on certain filters like status and date range.
*             - BulkUpdateOrders(List<OrderUpdateData> orderUpdates): 
*               Allows for the batch updating of orders based on provided data, such as changing order 
*               status or adding tracking numbers.
* 
*     OrderUpdateData:
*         Represents the data structure for updating order details.
*         Properties:
*             - status: The current status of the order (e.g., "Shipped", "Delivered", "Returned").
*             - trackingNumber: (Optional) The tracking number for shipped orders.
*             - estimatedDeliveryDate: (Optional) The estimated date of delivery for the order.
*             - notes: (Optional) Any additional notes or comments related to the order.
*             - cancelReason: (Optional) Reason for order cancellation, if applicable.
*             - returnReason: (Optional) Reason for order return, if applicable.
* 
* Dependencies:
*     - OrderService: Handles the CRUD operations related to orders by interacting with the order database.
*     - LoggerService: Logs events, warnings, and errors. Used here to capture any issues while processing orders.
* 
* Note:
*     Orders are crucial to the operation of any e-commerce platform. Thus, any updates or changes to orders 
*     must be conducted with care to ensure customer satisfaction and trust. Always ensure accuracy and 
*     timeliness when handling orders.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AdminOrdersController : ControllerBase
    {
        DECLARE OrderService orderService
        DECLARE LoggerService logger

        CONSTRUCTOR(OrderService oService, LoggerService logService)
        {
            INIT orderService with oService
            INIT logger with logService
        }

        // GET /api/admin/orders
        FUNCTION ListOrders(string? status = null, DateTime? fromDate = null, DateTime? toDate = null) RETURNS IActionResult
        {
            TRY
            {
                List<Order> orders = CALL orderService.ListOrders(status, fromDate, toDate)

                RETURN Ok with orders
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving orders: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // PUT /api/admin/orders
        FUNCTION BulkUpdateOrders(List<OrderUpdateData> orderUpdates) RETURNS IActionResult
        {
            TRY
            {
                CALL orderService.BulkUpdateOrders(orderUpdates)

                RETURN Ok with message "Orders updated successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while updating orders: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class OrderUpdateData
    {
        DECLARE string status
        DECLARE string? trackingNumber
        DECLARE DateTime? estimatedDeliveryDate
        DECLARE string? notes
        DECLARE string? cancelReason
        DECLARE string? returnReason
    }
}
