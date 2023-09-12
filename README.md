# Card Info Storage API

This is a Card Info Storage API built with C# that allows you to securely store and manage card information. This README provides essential information on how to set up, configure, and use the API effectively.

## Table of Contents
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Card Data Storage**: Safely store card information, including card numbers and expiration dates.
- **RESTful API**: Easily integrate the API into your applications.

## Prerequisites

Before setting up and using the Card Info Storage API, make sure you have the following prerequisites installed:

- [Visual Studio](https://visualstudio.microsoft.com/) or any C# development environment.
- [.NET Core](https://dotnet.microsoft.com/download) (at least version 3.1).

## Installation

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/keromaaa/card-api.git
   ```

2. Open the project in your preferred C# development environment (e.g., Visual Studio).

3. Restore the required packages by running the following command:

   ```bash
   dotnet restore
   ```

## Configuration

Before running the API, you need to configure the database connection and any other settings. You can do this by modifying the `appsettings.json` file. Here's an example configuration:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=CardInfoDb;User Id=username;Password=password;"
  },
  "JwtSettings": {
    "Key": "YourSecretKey",
    "Issuer": "YourIssuer",
    "Audience": "YourAudience",
    "DurationInMinutes": 60
  },
  "AllowedHosts": "*"
}
```

- Update the `ConnectionStrings` section with your database connection details.
- Update the `JwtSettings` section with your JWT (JSON Web Token) configuration.

## Usage

To run the API, build the project and start the application. You can use the development server provided by your development environment or run the following command:

```bash
dotnet run
```

By default, the API will be accessible at `http://localhost:5000`. You can change the port and other settings in the `appsettings.json` file.

## API Endpoints

The Card Info Storage API exposes the following endpoints:

- `POST /api/cards`: Create a new card record.
- `GET /api/cards`: Retrieve all cards.
- `DELETE /api/cards/{id}`: Delete card information by ID.

Please refer to the API documentation for detailed information on how to use each endpoint.

## Contributing

We welcome contributions to improve this API. If you find a bug, have a feature request, or want to contribute in any way, please open an issue or submit a pull request.

## License

This Card Info Storage API is open-source and available under the [MIT License](LICENSE). You are free to use, modify, and distribute it as needed.
