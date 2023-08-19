/*
* UserRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the User entity and its related entities within the E-Commerce application's database.
* 
* Class Definitions:
*     - UserRepository: A repository class that encapsulates the data access layer for Users and their associated entities such as payment methods, shipping addresses, and subscriptions.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddUser: Adds a new user to the database.
*         - GetAllUsers: Fetches all users along with their associated details.
*         - GetUserById: Retrieves a specific user by ID along with their associated details.
*         - UpdateUser: Updates the details of a specific user.
*         - DeleteUser: Removes a specific user from the database.
*         - GetUserByUsername: Fetches a user based on their username.
*         - AddPaymentMethodForUser: Adds a new payment method for a specific user.
*         - DeletePaymentMethod: Removes a specific payment method.
*         - AddShippingAddressForUser: Adds a new shipping address for a specific user.
*         - DeleteShippingAddress: Removes a specific shipping address.
*         - AddSubscriptionForUser: Adds a new subscription for a specific user.
*         - DeleteSubscription: Removes a specific subscription.
* 
*       - Relationships:
*         - Uses UserModel to interact with the User entity in the database.
*         - Uses PaymentMethodsModel to interact with the PaymentMethods entity in the database.
*         - Uses ShippingAddressModel to interact with the ShippingAddresses entity in the database.
*         - Uses SubscriptionModel to interact with the Subscriptions entity in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories.User
{
    DEFINE class UserRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(UserRepository(DbContext context))
        {
            _context = context
        }

        // USER METHODS:

        // Add a new user
        FUNCTION AddUser(UserModel user)
        {
            _context.Users.Add(user)
            _context.SaveChanges()
        }

        // Retrieve all users
        FUNCTION List<UserModel> GetAllUsers()
        {
            RETURN _context.Users.Include(paymentMethods).Include(shippingAddresses).Include(subscriptions).ToList()
        }

        // Retrieve a user by their ID
        FUNCTION UserModel GetUserById(int userId)
        {
            RETURN _context.Users.Include(paymentMethods).Include(shippingAddresses).Include(subscriptions).FirstOrDefault(user => user.UserId == userId)
        }

        // Update user details
        FUNCTION UpdateUser(UserModel updatedUser)
        {
            _context.Update(updatedUser)
            _context.SaveChanges()
        }

        // Delete a user by their ID
        FUNCTION DeleteUser(int userId)
        {
            DECLARE userToDelete = _context.Users.FirstOrDefault(user => user.UserId == userId)
            IF (userToDelete IS NOT NULL)
            {
                _context.Users.Remove(userToDelete)
                _context.SaveChanges()
            }
        }

        // Retrieve a user by username
        FUNCTION UserModel GetUserByUsername(string username)
        {
            RETURN _context.Users.Include(paymentMethods).Include(shippingAddresses).Include(subscriptions).FirstOrDefault(user => user.Username == username)
        }

        // PAYMENT METHOD METHODS:

        // Add a new payment method for a user
        FUNCTION AddPaymentMethodForUser(int userId, PaymentMethodsModel paymentMethod)
        {
            DECLARE user = GetUserById(userId)
            user.PaymentMethods.Add(paymentMethod)
            _context.SaveChanges()
        }

        // Delete a payment method for a user
        FUNCTION DeletePaymentMethod(int paymentMethodId)
        {
            DECLARE paymentMethodToDelete = _context.PaymentMethods.FirstOrDefault(payment => payment.PaymentMethodId == paymentMethodId)
            IF (paymentMethodToDelete IS NOT NULL)
            {
                _context.PaymentMethods.Remove(paymentMethodToDelete)
                _context.SaveChanges()
            }
        }

        // SHIPPING ADDRESS METHODS:

        // Add a new shipping address for a user
        FUNCTION AddShippingAddressForUser(int userId, ShippingAddressModel shippingAddress)
        {
            DECLARE user = GetUserById(userId)
            user.ShippingAddresses.Add(shippingAddress)
            _context.SaveChanges()
        }

        // Delete a shipping address for a user
        FUNCTION DeleteShippingAddress(int addressId)
        {
            DECLARE addressToDelete = _context.ShippingAddresses.FirstOrDefault(address => address.AddressId == addressId)
            IF (addressToDelete IS NOT NULL)
            {
                _context.ShippingAddresses.Remove(addressToDelete)
                _context.SaveChanges()
            }
        }

        // SUBSCRIPTION METHODS:

        // Add a new subscription for a user
        FUNCTION AddSubscriptionForUser(int userId, SubscriptionModel subscription)
        {
            DECLARE user = GetUserById(userId)
            user.Subscriptions.Add(subscription)
            _context.SaveChanges()
        }

        // Delete a subscription for a user
        FUNCTION DeleteSubscription(int subscriptionId)
        {
            DECLARE subscriptionToDelete = _context.Subscriptions.FirstOrDefault(sub => sub.SubscriptionId == subscriptionId)
            IF (subscriptionToDelete IS NOT NULL)
            {
                _context.Subscriptions.Remove(subscriptionToDelete)
                _context.SaveChanges()
            }
        }
    }
}
