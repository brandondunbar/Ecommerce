/*
* UsersController.cs
*
* Description:
*     Located in the ECommerceApp.Controllers namespace, this controller is tasked with managing user-related 
*     operations on the E-Commerce platform, encompassing user registration, authentication, and user profile retrieval.
* 
* Classes:
*     UsersController:
*         Methods:
*             - Register(UserRegistrationRequest registrationRequest): Registers new users on the platform, 
*               validating input data, hashing passwords, and storing user details in the database.
*             - Login(UserLoginRequest loginRequest): Authenticates users and, if successful, 
*               returns a JWT token for authenticated requests.
* 
*     UserRegistrationRequest:
*         Represents the data structure for registering users, capturing both personal details and credentials.
* 
*     UserLoginRequest:
*         Represents the data structure for user login, detailing credentials (email and password).
* 
*     User:
*         Represents a user in the database. 
*         Properties:
*             - UserId: The unique ID for the user.
*             - Username: The user's chosen username.
*             - PasswordHash: Hashed representation of the user's password.
*             - Email: The user's email address.
*             - FirstName: The user's first name.
*             - LastName: The user's last name.
*             - DateOfBirth: The user's date of birth.
*             - PhoneNumber: The user's phone number.
*             - ProfileImage: The URL or path to the user's profile image.
*             - IsActive: Indicates whether the user's account is active.
*             - Role: The user's role (e.g., "customer").
*             - LastLogin: Timestamp of the user's last login.
*             - DateRegistered: The date the user registered.
* 
* Dependencies:
*     - UserService: Handles user CRUD operations by interacting with the user database.
*     - PasswordHasher: Ensures passwords are hashed securely for storage.
*     - AuthService: Manages user authentication and JWT token creation.
*     - LoggerService: Logs events, warnings, and errors.
*     - EmailService: Sends emails, utilized here for sending welcome emails post-registration.
* 
* Note:
*     All modifications to this class should ensure the security and privacy principles are upheld. 
*     User data is sensitive, and its handling requires utmost care and adherence to best practices.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/



IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class UsersController : ControllerBase
    {
        DECLARE UserService userService
        DECLARE PasswordHasher passwordHasher
        DECLARE LoggerService logger
        DECLARE EmailService emailService
        DECLARE AuthService authService

        CONSTRUCTOR(UserService uService, PasswordHasher pHasher, LoggerService logService, EmailService eService, AuthService aService)
        {
            INIT userService with uService
            INIT passwordHasher with pHasher
            INIT logger with logService
            INIT emailService with eService
            INIT authService with aService
        }

        // POST /api/users/register
        FUNCTION Register(UserRegistrationRequest registrationRequest) RETURNS IActionResult
        {
            IF registrationRequest is null OR registrationRequest fields are not valid
                LOG warning "Invalid registration request"
                RETURN BadRequest with message "Invalid registration data"
            END IF

            IF CALL userService.UserExists(registrationRequest.Email, registrationRequest.Username)
                LOG warning "Attempt to register with existing email or username"
                RETURN Conflict with message "Email or username already exists"
            END IF

            TRY
            {
                string hashedPassword = CALL passwordHasher.HashPassword(registrationRequest.Password)

                User newUser = new User
                {
                    Username = registrationRequest.Username,
                    PasswordHash = hashedPassword,
                    Email = registrationRequest.Email,
                    FirstName = registrationRequest.FirstName,
                    LastName = registrationRequest.LastName,
                    DateOfBirth = registrationRequest.DateOfBirth,
                    PhoneNumber = registrationRequest.PhoneNumber,
                    ProfileImage = registrationRequest.ProfileImage,
                    IsActive = true,
                    Role = "customer",   // default role when registering
                    LastLogin = CURRENT_TIMESTAMP,
                    DateRegistered = CURRENT_TIMESTAMP
                }

                CALL userService.SaveUser(newUser)
                CALL emailService.SendWelcomeEmail(registrationRequest.Email)

                RETURN Created with newUser (excluding sensitive fields)
            }
            CATCH any exception as error
            {
                LOG error "Error while registering user: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/users/login
        FUNCTION Login(UserLoginRequest loginRequest) RETURNS IActionResult
        {
            IF loginRequest is null OR loginRequest fields are not valid
                LOG warning "Invalid login request"
                RETURN BadRequest with message "Invalid login data"
            END IF

            TRY
            {
                User user = CALL userService.AuthenticateUser(loginRequest.Email, loginRequest.Password)

                IF user is null
                    RETURN Unauthorized with message "Authentication failed"
                END IF

                IF user.IsLocked OR user.IsSuspended
                    RETURN Forbidden with message "Account locked or suspended"
                END IF

                string jwtToken = CALL authService.GenerateJWT(user)

                RETURN Ok with jwtToken
            }
            CATCH any exception as error
            {
                LOG error "Error while logging in user: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class UserRegistrationRequest
    {
        DECLARE string Username
        DECLARE string Email
        DECLARE string Password
        DECLARE string FirstName
        DECLARE string LastName
        DECLARE date DateOfBirth
        DECLARE string PhoneNumber
        DECLARE string ProfileImage
    }

    DEFINE class UserLoginRequest
    {
        DECLARE string Email
        DECLARE string Password
    }

    DEFINE class User
    {
        DECLARE int UserId
        DECLARE string Username
        DECLARE string PasswordHash
        DECLARE string Email
        DECLARE string FirstName
        DECLARE string LastName
        DECLARE date DateRegistered
        DECLARE date DateOfBirth
        DECLARE string PhoneNumber
        DECLARE string ProfileImage
        DECLARE bool IsActive
        DECLARE string Role
        DECLARE timestamp LastLogin
    }
}
