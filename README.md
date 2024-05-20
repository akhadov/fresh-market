## .NET E-Commerce Reference Application - "Fresh Market"

A reference .NET application implementing an eCommerce web site using a clean architecture.

##  Features

- 🌐 Minimal Endpoints - because it's fast & simple. ⚡
- 🔑 Global Exception Handling - it's important to handle exceptions in a consistent way & protect sensitive information
- 📝 OpenAPI/Swagger - easily document your API
- 🗄️ Entity Framework Core - for data access
    - Comes with Migrations & Data Seeding
- 🧩 Repository Pattern - abstract EF Core away from your business logic
- 🔀 CQRS - for separation of concerns
- 📦 MediatR - for decoupling your application
- 📦 FluentValidation - for validating requests
- 🆔 Strongly Typed IDs - to combat primitive obsession
    - Entity Framework can automatically convert the int, Guid, nvarchar(..) to strongly typed ID.
      
- 🧪 Testing
    - Simpler Unit Tests for Application
    - Better Integration Tests
        - Integration Tests at Unit Test speed
        - Test Commands and Queries against a Real database

- Architecture Tests
    - The tests are automated so discovering the defects is fast
 
##  Getting Started

Use these instructions to get the project up and running.

### Prerequisites

You will need the following tools:

* [Visual Studio or VS Code](https://visualstudio.microsoft.com/downloads/), or [Rider](https://www.jetbrains.com/rider/download/)
* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)

### Setup

Follow these steps to get your development environment set up:

1. Clone the repository
2. At the root directory, restore required packages by running:

```bash
 dotnet restore
```

3. Next, build the solution by running:

```bash
dotnet build
```

5. Launch the back end within the `\Src\WebApi` directory by running:

```bash
dotnet run
```
6. Launch [https://localhost:44376/api](http://localhost:44376/api) in your browser to view the API

## Technologies

* .NET 8
* ASP.NET Core 8
* ASP.NET MVC 
* Entity Framework Core 8

### Other Packages

* MediatR
* FluentValidation
* Serilog
* OpenApi
* Swashbuckle

### Testing Packages

* xUnit
* NSubstitute
* TestContainers
* Fluent Assertions
* Respawn
* Bogus

## License

This project is licensed under the MIT License.
