/*
* ProductImagesController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller manages operations related to product images 
*     within the E-Commerce platform. It provides endpoints for retrieving images associated with a product, uploading 
*     new images, and deleting existing images.
* 
* Classes:
*     ProductImagesController:
*         Methods:
*             - GetProductImages(int productId): Retrieves all images linked to a specific product. 
*               If no images are found, it returns a "Product not found" message.
*             - UploadProductImage(int productId, BINARY imageData): Validates incoming image data and uploads the image 
*               for the specified product if valid.
*             - DeleteProductImage(int productId, string imageId): Deletes a specific image associated with a product.
* 
*     Image:
*         Represents a product image within the system. 
*         Properties:
*             - Id: Unique identifier for the image.
*             - Url: The URL or path to access the image.
*             - AltText: Alternative text for the image, enhancing accessibility.
*             - UploadedAt: The date and time the image was uploaded.
* 
* Dependencies:
*     - ImageService: Handles CRUD operations for product images.
*     - LoggerService: Logs events, warnings, and errors.
* 
* Note:
*     Ensure the images are handled securely and efficiently. Proper validation is needed during upload to prevent 
*     potential vulnerabilities or inappropriate content. Additionally, consider optimizing images for web use to 
*     improve loading times and user experience.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/13/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class ProductImagesController : ControllerBase
    {
        DECLARE ImageService imageService
        DECLARE LoggerService logger

        CONSTRUCTOR(ImageService iService, LoggerService logService)
        {
            INIT imageService with iService
            INIT logger with logService
        }

        // GET /api/products/{productId}/images
        FUNCTION GetProductImages(int productId) RETURNS IActionResult
        {
            TRY
            {
                List<Image> images = CALL imageService.GetImagesForProduct(productId)

                IF images is empty
                    RETURN NotFound with message "Product not found"
                END IF

                RETURN Ok with images
            }
            CATCH any exception as error
            {
                LOG error "Error while retrieving product images: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/products/{productId}/images
        FUNCTION UploadProductImage(int productId, BINARY imageData) RETURNS IActionResult
        {
            IF imageData is null OR not valid
                RETURN BadRequest with message "Invalid image data"
            END IF

            TRY
            {
                Image uploadedImage = CALL imageService.UploadImageForProduct(productId, imageData)

                RETURN Created with uploadedImage
            }
            CATCH any exception as error
            {
                LOG error "Error while uploading product image: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // DELETE /api/products/{productId}/images
        FUNCTION DeleteProductImage(int productId, string imageId) RETURNS IActionResult
        {
            TRY
            {
                BOOL result = CALL imageService.DeleteImage(productId, imageId)

                IF result is false
                    RETURN NotFound with message "Image or product not found"
                END IF

                RETURN NoContent
            }
            CATCH any exception as error
            {
                LOG error "Error while deleting product image: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class Image
    {
        DECLARE string Id
        DECLARE string Url
        DECLARE string AltText
        DECLARE DateTime UploadedAt
    }
}
