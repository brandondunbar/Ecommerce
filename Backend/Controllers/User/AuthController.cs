/*
* AuthController.cs
*
* Description:
*     This controller, part of the ECommerceApp.Controllers namespace, handles authentication-related functionalities 
*     within the ECommerceApp. Its main role is to manage user authentication, using JWT for secure token generation.
* 
* Classes:
*     AuthController:
*         Methods:
*             - Authorize(UserLoginRequest loginRequest): Authenticates a user and, upon successful validation, returns a JWT token.
* 
*     UserLoginRequest:
*         Represents the data structure for user authentication.
*         Properties:
*             - Username: The username of the user.
*             - Password: The user's password.
* 
* Dependencies:
*     - AuthService: Provides methods related to JWT token generation and validation.
*     - UserService: Handles user-related operations, particularly user credential validation.
*     - LoggerService: Responsible for logging events, warnings, and errors.
* 
* Note:
*     Ensure that user authentication is handled securely. Any changes to this class should be made with caution, 
*     considering the importance of security in authentication processes.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/


IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class AuthController
    {
        // Dependency services for authentication and user operations
        DECLARE AuthService authenticationService
        DECLARE UserService userService
        DECLARE LoggerService logger

        // Constructor for dependency injection
        CONSTRUCTOR(AuthService authService, UserService uService, LoggerService logService)
        {
            INIT authenticationService with authService
            INIT userService with uService
            INIT logger with logService
        }

        // POST /api/authorize
        FUNCTION Authorize(UserLoginRequest loginRequest) RETURNS IActionResult
        {
            // Basic request validation
            IF loginRequest is null OR loginRequest fields are empty
                LOG warning "Invalid client request during authorization"
                RETURN BadRequest with message "Invalid client request"
            END IF

            TRY
            {
                // Use UserService to validate the user credentials
                User authenticatedUser = CALL userService.ValidateUser(loginRequest.Username, loginRequest.Password)

                IF authenticatedUser is null
                    LOG warning "Unauthorized access attempt"
                    RETURN Unauthorized with message "Invalid username or password"
                END IF

                // Generate JWT token using AuthService
                string token = CALL authenticationService.GenerateJWTToken(authenticatedUser)

                RETURN Ok with the token
            }
            CATCH any exception as error
            {
                LOG error with error details
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }
    
    // Data models for request and response can be defined here or in a separate file
    DEFINE class UserLoginRequest
    {
        DECLARE string Username
        DECLARE string Password
    }
}

