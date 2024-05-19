## .NET E-Commerce Reference Application - "Fresh Market"

A reference .NET application implementing an eCommerce web site using a clean architecture.

## ✨ Features

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
 
## 🎉 Getting Started

Use these instructions to get the project up and running.

### Prerequisites

You will need the following tools:

* [Visual Studio or VS Code](https://visualstudio.microsoft.com/downloads/), or [Rider](https://www.jetbrains.com/rider/download/)
* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
* [Node.js](https://nodejs.org/en/) version 20.10 LTS or later - Recommended to install using [nvm](https://github.com/nvm-sh/nvm) or [nvm for Windows](https://github.com/coreybutler/nvm-windows)
* Angular CLI (version 17 or later) - install by running `npm install -g @angular/cli`

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

5. Once the front end has started, within the `\Src\WebUI` directory, launch the back end by running:

```bash
dotnet run
```

6. Launch [https://localhost:44427/](https://localhost:44427/) in your browser to view the Web UI

7. Launch [https://localhost:44376/api](http://localhost:44376/api) in your browser to view the API

## Technologies

* .NET 8
* ASP.NET Core 8
* Entity Framework Core 8
* Angular 15

### Other Packages

* MediatR
* FluentValidation
* AutoMapper
* Ardalis.Specification
* Ardalis.GuardClauses

### Testing Packages

* xUnit
* NSubstitute
* TestContainers
* Fluent Assertions
* Respawn
* Bogus

## Marketing

Marketing site can be found at [northwind365.com](https://northwind365.com/) which is deployed
from [Northwind365.Website](https://github.com/SSWConsulting/Northwind365.Website).

## License

This project is licensed under the MIT License - see
the [LICENSE.md](https://github.com/SSWConsulting/Northwind365/blob/main/LICENSE) file for details.
