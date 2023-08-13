/*
* UserPasswordController.cs
*
* Description:
*     This controller is part of the ECommerceApp.Controllers namespace and oversees password-related operations 
*     within the ECommerceApp. It provides functionalities for users to initiate the password reset process and 
*     execute the reset based on a valid token.
* 
* Classes:
*     UserPasswordController:
*         Methods:
*             - ForgotPassword(ForgotPasswordRequest request): Initiates the password reset process by sending a link or code to the registered email.
*             - ResetPassword(ResetPasswordRequest request): Resets the user's password using the provided reset token and new password details.
* 
*     ForgotPasswordRequest:
*         Represents the request structure for initiating the password reset.
* 
*     ResetPasswordRequest:
*         Represents the request structure for resetting the password with the reset token and new password details.
* 
* Dependencies:
*     - UserService: Provides methods and functionalities related to users in the database.
*     - PasswordResetService: Handles the generation and validation of password reset tokens.
*     - PasswordHasher: Ensures passwords are securely hashed and provides comparison methods.
*     - LoggerService: Responsible for logging events, warnings, and errors.
*     - EmailService: Sends out emails, notably for the password reset process.
* 
* Note:
*     Ensure that the user's email is verified before initiating the password reset process. Also, ensure the reset token's validity during the reset process.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/12/23
*/



IMPORT necessary libraries and services

NAMESPACE ECommerceApp.Controllers
{
    DEFINE class UserPasswordController : ControllerBase
    {
        DECLARE UserService userService
        DECLARE PasswordResetService passwordResetService
        DECLARE PasswordHasher passwordHasher
        DECLARE LoggerService logger
        DECLARE EmailService emailService

        CONSTRUCTOR(UserService uService, PasswordResetService prService, PasswordHasher pHasher, LoggerService logService, EmailService eService)
        {
            INIT userService with uService
            INIT passwordResetService with prService
            INIT passwordHasher with pHasher
            INIT logger with logService
            INIT emailService with eService
        }

        // POST /api/users/forgot-password
        FUNCTION ForgotPassword(ForgotPasswordRequest forgotPasswordRequest) RETURNS IActionResult
        {
            IF forgotPasswordRequest is null OR forgotPasswordRequest.Email is not valid
                LOG warning "Invalid forgot password request"
                RETURN BadRequest with message "Invalid email format"
            END IF

            User user = CALL userService.FindByEmail(forgotPasswordRequest.Email)

            IF user is null
                RETURN NotFound with message "User not found with the provided email"
            END IF

            TRY
            {
                string resetToken = CALL passwordResetService.GenerateResetToken(user)

                CALL emailService.SendPasswordResetEmail(user.Email, resetToken)

                RETURN Ok with message "Password reset request received. Check your email for further instructions."
            }
            CATCH any exception as error
            {
                LOG error "Error while processing forgot password request: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }

        // POST /api/users/reset-password
        FUNCTION ResetPassword(ResetPasswordRequest resetPasswordRequest) RETURNS IActionResult
        {
            IF resetPasswordRequest is null OR resetPasswordRequest fields are not valid
                LOG warning "Invalid reset password request"
                RETURN BadRequest with message "Invalid request data"
            END IF

            IF resetPasswordRequest.NewPassword != resetPasswordRequest.ConfirmPassword
                RETURN BadRequest with message "New password and confirmation do not match"
            END IF

            TRY
            {
                User user = CALL passwordResetService.ValidateResetToken(resetPasswordRequest.ResetToken)

                IF user is null
                    RETURN Unauthorized with message "Invalid or expired reset token"
                END IF

                string hashedPassword = CALL passwordHasher.HashPassword(resetPasswordRequest.NewPassword)
                CALL userService.UpdateUserPassword(user, hashedPassword)

                RETURN Ok with message "Password reset successfully"
            }
            CATCH any exception as error
            {
                LOG error "Error while resetting password: {error details}"
                RETURN StatusCode 500 with message "Internal server error"
            }
        }
    }

    DEFINE class ForgotPasswordRequest
    {
        DECLARE string Email
    }

    DEFINE class ResetPasswordRequest
    {
        DECLARE string ResetToken
        DECLARE string NewPassword
        DECLARE string ConfirmPassword
    }
}
