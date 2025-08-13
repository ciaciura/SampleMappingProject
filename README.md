# SampleMappingProject

## Overview
SampleMappingProject is a .NET solution demonstrating a clean separation of concerns for mapping between view models and persistence models, with a focus on testability and maintainability. The solution is organized into three main projects:

- **SampleMappingProject.Console**: The main console application. Demonstrates mapping between user-facing view models and persistence models, and provides example usage.
- **SampleMappingProject.Commons**: A class library containing base mapping and test classes, designed for reuse and extensibility.
- **SampleMappingProject.Tests**: Unit tests for the mapping logic, ensuring correctness and reliability.

## Project Structure

- `SampleMappingProject.Console`
  - Contains the main entry point (`Program.cs`).
  - Implements `UserView` (view model) and `UserModel` (persistence model).
  - Demonstrates mapping logic and example data transformations.

- `SampleMappingProject.Commons`
  - Contains abstract base classes for mapping (`FrontViewBase`) and for mapping tests (`FrontViewMappingTestBase`).
  - Designed to be reused by other projects that need similar mapping infrastructure.

- `SampleMappingProject.Tests`
  - Contains unit tests for the mapping logic, using xUnit.
  - Example: `UserViewMappingTests` verifies that mapping between `UserView` and `UserModel` works as expected.

## Key Concepts

- **Mapping**: The project uses generic base classes to define mapping logic between view and model types, supporting both creation and update scenarios.
- **Testability**: Abstract test base classes allow for easy and consistent testing of mapping logic across different view/model pairs.
- **Separation of Concerns**: By splitting base logic into a commons library, the solution encourages modularity and code reuse.

## How to Build and Run

1. **Build the solution:**
   ```sh
   dotnet build
   ```
2. **Run the console app:**
   ```sh
   dotnet run --project SampleMappingProject.Console
   ```
3. **Run the tests:**
   ```sh
   dotnet test
   ```

## Requirements
- .NET 8.0 SDK or later

## License
This project is for demonstration and educational purposes.
