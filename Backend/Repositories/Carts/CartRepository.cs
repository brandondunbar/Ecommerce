/*
* CartRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the ShoppingCart and CartItem entities within the E-Commerce application's database.
* 
* Class Definitions:
*     - CartRepository: A repository class that encapsulates the data access layer for both the ShoppingCart and CartItem entities.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - GetCartByUserId: Retrieves a shopping cart entity by its associated user ID.
*         - CreateCartForUser: Creates a new shopping cart for a specified user.
*         - ClearCart: Clears all items from a specified user's cart.
*         - AddItemToCart: Adds a new cart item to a user's shopping cart.
*         - RemoveItemFromCart: Removes a specified cart item from a user's shopping cart.
*         - UpdateItemQuantity: Updates the quantity of a specified cart item in a user's shopping cart.
*         - GetAllItemsInCart: Fetches all cart items associated with a specified user's shopping cart.
* 
*       - Relationships:
*         - ShoppingCartModel: Uses the ShoppingCartModel to interact with the ShoppingCart entities in the database.
*         - CartItemModel: Uses the CartItemModel to interact with the CartItem entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories.Cart
{
    DEFINE class CartRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(CartRepository(DbContext context))
        {
            _context = context
        }

        // Methods specific to ShoppingCartModel

        // Retrieve a shopping cart by user ID
        FUNCTION ShoppingCartModel GetCartByUserId(int userId)
        {
            RETURN _context.ShoppingCarts.Include("CartItems").FirstOrDefault(cart => cart.UserId == userId)
        }

        // Create a new shopping cart for a user
        FUNCTION CreateCartForUser(int userId)
        {
            DECLARE newCart = NEW ShoppingCartModel { UserId = userId }
            _context.ShoppingCarts.Add(newCart)
            _context.SaveChanges()
        }

        // Clear all items from a user's cart
        FUNCTION ClearCart(int userId)
        {
            DECLARE cart = GetCartByUserId(userId)
            IF (cart IS NOT NULL)
            {
                _context.CartItems.RemoveRange(cart.CartItems)
                _context.SaveChanges()
            }
        }

        // Methods specific to CartItemModel

        // Add a new item to a user's cart
        FUNCTION AddItemToCart(int userId, CartItemModel item)
        {
            DECLARE cart = GetCartByUserId(userId)
            IF (cart IS NOT NULL)
            {
                cart.CartItems.Add(item)
                _context.SaveChanges()
            }
        }

        // Remove an item from a user's cart
        FUNCTION RemoveItemFromCart(int userId, int itemId)
        {
            DECLARE cart = GetCartByUserId(userId)
            IF (cart IS NOT NULL)
            {
                DECLARE itemToRemove = cart.CartItems.FirstOrDefault(item => item.CartItemId == itemId)
                IF (itemToRemove IS NOT NULL)
                {
                    _context.CartItems.Remove(itemToRemove)
                    _context.SaveChanges()
                }
            }
        }

        // Update the quantity of an item in a user's cart
        FUNCTION UpdateItemQuantity(int userId, int itemId, int newQuantity)
        {
            DECLARE cart = GetCartByUserId(userId)
            IF (cart IS NOT NULL)
            {
                DECLARE itemToUpdate = cart.CartItems.FirstOrDefault(item => item.CartItemId == itemId)
                IF (itemToUpdate IS NOT NULL)
                {
                    itemToUpdate.Quantity = newQuantity
                    _context.SaveChanges()
                }
            }
        }

        // Fetch all items in a user's cart
        FUNCTION List<CartItemModel> GetAllItemsInCart(int userId)
        {
            DECLARE cart = GetCartByUserId(userId)
            IF (cart IS NOT NULL)
            {
                RETURN cart.CartItems
            }
            ELSE
            {
                RETURN new List<CartItemModel>()
            }
        }
    }
}
