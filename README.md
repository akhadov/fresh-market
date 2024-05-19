## .NET E-Commerce Reference Application - "Fresh Market"

A reference .NET application implementing an eCommerce web site using a clean architecture.

## ✨ Features

- ⚖️ EditorConfig - comes with the [SSW.EditorConfig](https://github.com/SSWConsulting/SSW.EditorConfig)
    - Maintain consistent coding styles for individual developers or teams of developers working on the same project using different IDEs
    - as per [ssw.com.au/rules/consistent-code-style/](https://ssw.com.au/rules/consistent-code-style/)
- 📦 Slim - no authentication provider, no authorization & no UI framework
    - You can add these yourself or use one of our reference architectures from [awesome-clean-architecture](https://github.com/SSWConsulting/awesome-clean-architecture)
    - as per [ssw.com.au/rules/choosing-authentication/](https://ssw.com.au/rules/choosing-authentication/)
- 🌐 Minimal Endpoints - because it's fast & simple. ⚡
    - Extension methods to ensure consistent HTTP Verbs & Status Codes
- 🔑 Global Exception Handling - it's important to handle exceptions in a consistent way & protect sensitive information
    - Transforms exceptions into a consistent format following the [RFC7231 memo](https://datatracker.ietf.org/doc/html/rfc7231#section-6.1)
- 📝 OpenAPI/Swagger - easily document your API
    - as per [ssw.com.au/rules/do-you-document-your-webapi/](https://ssw.com.au/rules/do-you-document-your-webapi/)
- 🗄️ Entity Framework Core - for data access
    - Comes with Migrations & Data Seeding
    - as per [ssw.com.au/rules/rules-to-better-entity-framework/](https://ssw.com.au/rules/rules-to-better-entity-framework/)
- 🧩 Specification Pattern - abstract EF Core away from your business logic
- 🔀 CQRS - for separation of concerns
    - as per [ssw.com.au/rules/keep-business-logic-out-of-the-presentation-layer/](https://ssw.com.au/rules/keep-business-logic-out-of-the-presentation-layer/)
- 📦 MediatR - for decoupling your application
- 📦 FluentValidation - for validating requests
    - as per [ssw.com.au/rules/use-fluent-validation/](https://ssw.com.au/rules/use-fluent-validation/)
- 📦 AutoMapper - for mapping between objects
- 🆔 Strongly Typed IDs - to combat primitive obsession
    - e.g. pass `CustomerId` type into methods instead of `int`, or `Guid`
    - Entity Framework can automatically convert the int, Guid, nvarchar(..) to strongly typed ID.
- 🔨 `dotnet new` cli template - to get you started quickly
- 📁 Directory.Build.Props
    - Consistent build configuration across all projects in the solution
        - e.g. Treating Warnings as Errors for Release builds
    - Custom per project
        - e.g. for all test projects we can ensure that the exact same versions of common packages are referenced
        - e.g. XUnit and NSubstitute packages for all test projects
- 🧪 Testing
    - as per [ssw.com.au/rules/rules-to-better-testing/](https://www.ssw.com.au/rules/rules-to-better-testing/)
    - Simpler Unit Tests for Application
        - **No Entity Framework mocking required** thanks to **Specifications**
        - as per [ssw.com.au/rules/rules-to-better-unit-tests/](https://www.ssw.com.au/rules/rules-to-better-unit-tests/)
    - Better Integration Tests
        - Using [Respawn](https://github.com/jbogard/Respawn) and [TestContainers](https://dotnet.testcontainers.org/)
        - Integration Tests at Unit Test speed
        - Test Commands and Queries against a Real database
        - No Entity Framework mocking required
        - No need for In-memory database provider
<!-- Commenting out pending #100     - Using [Wire-Mock](https://wiremock.org/) to mock out external services for controlled Integration Tests
      - e.g. grab real request and responses from external system and then replaying them in the tests -->
- Architecture Tests
    - Using [NetArchTest](https://github.com/BenMorris/NetArchTest)
    - Know that the team is following the same Clean Architecture fundamentals
    - The tests are automated so discovering the defects is fast
<!-- Commenting out pending #101  - Mutation Testing
    - Test our tests!
    - Helps discover the false-positives in our tests
      - you will know when your tests pass when they should have failed
    - Inserts bugs into the production code to make sure our tests are effective and testing the right behavior
    - Using [Stryker Mutator](https://stryker-mutator.io/) -->
