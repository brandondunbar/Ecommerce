/*
* BaseRepository.cs
* 
* Module Description:
*     This foundational module acts as the base repository for the E-Commerce application's data layer. It offers generic CRUD operations that can be inherited by specific repositories tailored to individual entities.
* 
* Class Definitions:
*     - BaseRepository<T>: A generic repository class offering CRUD operations for any given entity.
*       - Properties:
*         - _context: The database context used to interact with the database.
*         - _entities: The set of entities of a given type to interact with in the database.
* 
*       - Methods:
*         - Add: Adds a new entity of type T to the database.
*         - Update: Updates an existing entity of type T in the database.
*         - Delete: Removes an entity of type T from the database.
*         - GetById: Fetches an entity of type T by its primary key.
*         - GetAll: Retrieves all entities of type T from the database.
*         - Save: Commits changes made to the database context.
*         - Dispose: Disposes of the database context, releasing resources.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/

NAMESPACE ECommerceApp.Data.Repositories
{
    DEFINE class BaseRepository<T> where T : class
    {
        DECLARE private DbContext _context
        DECLARE private DbSet<T> _entities

        // Constructor
        CONSTRUCTOR(BaseRepository(DbContext context))
        {
            _context = context
            _entities = context.Set<T>()
        }

        // CRUD Operations

        // Add a new entity
        FUNCTION Add(T entity)
        {
            _entities.Add(entity)
        }

        // Update an existing entity
        FUNCTION Update(T entity)
        {
            _entities.Update(entity)
        }

        // Delete an entity
        FUNCTION Delete(T entity)
        {
            _entities.Remove(entity)
        }

        // Retrieve an entity by its primary key
        FUNCTION T GetById(int id)
        {
            RETURN _entities.Find(id)
        }

        // Retrieve all entities of a given type
        FUNCTION IEnumerable<T> GetAll()
        {
            RETURN _entities.ToList()
        }

        // Persist changes to the database
        FUNCTION Save()
        {
            _context.SaveChanges()
        }

        // Optional: Dispose of the database context
        FUNCTION Dispose()
        {
            _context.Dispose()
        }
    }
}
