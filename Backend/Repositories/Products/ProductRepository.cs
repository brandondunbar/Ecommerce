/*
* ProductRepository.cs
* 
* Module Description:
*     This module provides the implementation for the operations and interactions with the Product-related entities (Product, Review, Category, Tag) within the E-Commerce application's database.
* 
* Class Definitions:
*     - ProductRepository: A repository class that encapsulates the data access layer for Product and its associated entities.
*       - Properties:
*         - _context: The database context for accessing the database.
* 
*       - Methods:
*         - Product-related methods: Provides CRUD operations for products.
*         - Review-related methods: Allows adding of reviews and fetching reviews by product.
*         - Category-related methods: Facilitates CRUD operations for categories.
*         - Tag-related methods: Facilitates CRUD operations for tags.
* 
*       - Relationships:
*         - Uses ProductModel, ReviewModel, CategoryModel, and TagModel to interact with respective entities in the database.
* 
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*     - BaseRepository: Inherits functionalities from the BaseRepository class.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/19/23
*/


NAMESPACE ECommerceApp.Data.Repositories.Product
{
    DEFINE class ProductRepository : BaseRepository
    {
        DECLARE private DbContext _context

        // Constructor
        CONSTRUCTOR(ProductRepository(DbContext context))
        {
            _context = context
        }

        // PRODUCT METHODS:

        // Add a new product
        FUNCTION AddProduct(ProductModel product)
        {
            _context.Products.Add(product)
            _context.SaveChanges()
        }

        // Retrieve all products
        FUNCTION List<ProductModel> GetAllProducts()
        {
            RETURN _context.Products.ToList()
        }

        // Retrieve a product by its ID
        FUNCTION ProductModel GetProductById(int productId)
        {
            RETURN _context.Products.FirstOrDefault(product => product.ProductId == productId)
        }

        // Update product details
        FUNCTION UpdateProduct(ProductModel updatedProduct)
        {
            _context.Update(updatedProduct)
            _context.SaveChanges()
        }

        // Delete a product by its ID
        FUNCTION DeleteProduct(int productId)
        {
            DECLARE productToDelete = _context.Products.FirstOrDefault(product => product.ProductId == productId)
            IF (productToDelete IS NOT NULL)
            {
                _context.Products.Remove(productToDelete)
                _context.SaveChanges()
            }
        }

        // REVIEW METHODS:

        // Add a new review for a product
        FUNCTION AddReview(ReviewModel review)
        {
            _context.Reviews.Add(review)
            _context.SaveChanges()
        }

        // Retrieve all reviews for a specific product
        FUNCTION List<ReviewModel> GetReviewsByProductId(int productId)
        {
            RETURN _context.Reviews.Where(review => review.ProductId == productId).ToList()
        }

        // CATEGORY METHODS:

        // Add a new category
        FUNCTION AddCategory(CategoryModel category)
        {
            _context.Categories.Add(category)
            _context.SaveChanges()
        }

        // Retrieve all categories
        FUNCTION List<CategoryModel> GetAllCategories()
        {
            RETURN _context.Categories.ToList()
        }

        // TAG METHODS:

        // Add a new tag
        FUNCTION AddTag(TagModel tag)
        {
            _context.Tags.Add(tag)
            _context.SaveChanges()
        }

        // Retrieve all tags
        FUNCTION List<TagModel> GetAllTags()
        {
            RETURN _context.Tags.ToList()
        }
    }
}
