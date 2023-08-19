/*
* TransactionRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Transaction entity within the E-Commerce application's database.
* 
* Class Definitions:
*     - TransactionRepository: A repository class that encapsulates the data access layer for Transactions.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - AddTransaction: Adds a new transaction to the database.
*         - GetAllTransactions: Fetches all transactions from the database.
*         - GetTransactionById: Retrieves a specific transaction by its ID.
*         - UpdateTransaction: Updates the details of a specific transaction.
*         - DeleteTransaction: Removes a specific transaction from the database.
*         - GetTransactionsByUserId: Fetches all transactions associated with a specific user.
*         - GetTransactionsByDateRange: Retrieves transactions that occurred within a specific date range.
* 
*       - Relationships:
*         - Uses TransactionModel to interact with the Transaction entity in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories.Transaction
{
    DEFINE class TransactionRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(TransactionRepository(DbContext context))
        {
            _context = context
        }

        // TRANSACTION METHODS:

        // Add a new transaction
        FUNCTION AddTransaction(TransactionModel transaction)
        {
            _context.Transactions.Add(transaction)
            _context.SaveChanges()
        }

        // Retrieve all transactions
        FUNCTION List<TransactionModel> GetAllTransactions()
        {
            RETURN _context.Transactions.ToList()
        }

        // Retrieve a transaction by its ID
        FUNCTION TransactionModel GetTransactionById(int transactionId)
        {
            RETURN _context.Transactions.FirstOrDefault(transaction => transaction.TransactionId == transactionId)
        }

        // Update transaction details
        FUNCTION UpdateTransaction(TransactionModel updatedTransaction)
        {
            _context.Update(updatedTransaction)
            _context.SaveChanges()
        }

        // Delete a transaction by its ID
        FUNCTION DeleteTransaction(int transactionId)
        {
            DECLARE transactionToDelete = _context.Transactions.FirstOrDefault(transaction => transaction.TransactionId == transactionId)
            IF (transactionToDelete IS NOT NULL)
            {
                _context.Transactions.Remove(transactionToDelete)
                _context.SaveChanges()
            }
        }

        // Retrieve all transactions for a specific user
        FUNCTION List<TransactionModel> GetTransactionsByUserId(int userId)
        {
            RETURN _context.Transactions.Where(transaction => transaction.UserId == userId).ToList()
        }

        // Retrieve all transactions within a specific date range
        FUNCTION List<TransactionModel> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            RETURN _context.Transactions.Where(transaction => transaction.TransactionDate >= startDate AND transaction.TransactionDate <= endDate).ToList()
        }
    }
}
