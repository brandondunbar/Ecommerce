/*
* OrderRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Order entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - OrderRepository: A repository class that encapsulates the data access layer for the Order entity.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddOrder: Adds a new order record to the database.
*         - GetAllOrders: Retrieves all orders from the database.
*         - GetOrderById: Fetches a specific order by its ID.
*         - GetOrdersByUserId: Retrieves all orders associated with a specific user ID.
*         - GetOrdersByDateRange: Fetches orders that fall within a specified date range.
*         - GetOrdersByStatus: Retrieves orders based on a specified status.
*         - UpdateOrderStatus: Updates the status of a specific order.
*         - DeleteOrder: Removes a specified order record from the database based on its ID.
* 
*       - Relationships:
*         - OrderModel: Uses the OrderModel to interact with the Order entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/


NAMESPACE ECommerceApp.Data.Repositories.Order
{
    DEFINE class OrderRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(OrderRepository(DbContext context))
        {
            _context = context
        }

        // Add a new order
        FUNCTION AddOrder(OrderModel order)
        {
            _context.Orders.Add(order)
            _context.SaveChanges()
        }

        // Retrieve all orders
        FUNCTION List<OrderModel> GetAllOrders()
        {
            RETURN _context.Orders.ToList()
        }

        // Retrieve order by its ID
        FUNCTION OrderModel GetOrderById(int orderId)
        {
            RETURN _context.Orders.FirstOrDefault(order => order.OrderId == orderId)
        }

        // Retrieve orders for a specific user
        FUNCTION List<OrderModel> GetOrdersByUserId(int userId)
        {
            RETURN _context.Orders.Where(order => order.UserId == userId).ToList()
        }

        // Retrieve orders within a date range
        FUNCTION List<OrderModel> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            RETURN _context.Orders.Where(order => order.OrderDate >= startDate AND order.OrderDate <= endDate).ToList()
        }

        // Retrieve orders by status (e.g., 'Pending', 'Shipped', 'Delivered')
        FUNCTION List<OrderModel> GetOrdersByStatus(string status)
        {
            RETURN _context.Orders.Where(order => order.Status == status).ToList()
        }

        // Update an order's status
        FUNCTION UpdateOrderStatus(int orderId, string newStatus)
        {
            DECLARE orderToUpdate = _context.Orders.FirstOrDefault(order => order.OrderId == orderId)
            IF (orderToUpdate IS NOT NULL)
            {
                orderToUpdate.Status = newStatus
                _context.SaveChanges()
            }
        }

        // Delete an order by its ID
        FUNCTION DeleteOrder(int orderId)
        {
            DECLARE orderToDelete = _context.Orders.FirstOrDefault(order => order.OrderId == orderId)
            IF (orderToDelete IS NOT NULL)
            {
                _context.Orders.Remove(orderToDelete)
                _context.SaveChanges()
            }
        }
    }
}
