# ASP.NET Email Authentication

This ASP.NET Core MVC application provides functionalities for user registration, login, and SMTP email authentication.

## Features

- **User Registration**: Users can register with a unique username, email, and password.
- **User Login**: Registered users can securely log in with their credentials.
- **Session Management**: User sessions are managed to ensure authenticated access to protected routes.
- **SMTP Email Authentication**: Allows sending emails using the SMTP protocol for authentication and verification purposes.

## Installation

1. Clone this repository to your local machine.
2. Open the solution file (`ASP.NET-Email-Auth.sln`) in Visual Studio.
3. Build and run the project.
4. Ensure you have configured the necessary SMTP settings in `HomeController.cs` for email sending functionality.

## Usage

1. Navigate to the registration page to create a new account.
2. Log in with your registered credentials.
3. Access the email authentication feature in the provided interface.
4. Customize the email content and recipient as needed.

## Technologies Used

- ASP.NET Core MVC
- C#
- MailKit for SMTP email functionality
- Entity Framework Core (optional, if using a database)

## Contributing

Contributions are welcome! If you have any suggestions, bug reports, or feature requests, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
