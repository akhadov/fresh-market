<p align="center">
	<a>
		<img src="assets/smartstore-icon-whitebg.png" alt="Smartstore" width="120">
	</a>
</p>

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
<!-- Commenting out pending #101  - Mutation Testing
    - Test our tests!
    - Helps discover the false-positives in our tests
      - you will know when your tests pass when they should have failed
    - Inserts bugs into the production code to make sure our tests are effective and testing the right behavior
    - Using [Stryker Mutator](https://stryker-mutator.io/) -->
