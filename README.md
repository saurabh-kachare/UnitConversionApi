# Unit Conversion API

## Overview

Unit Conversion API is a RESTful ASP.NET Core Web API that converts numerical values between different units of measurement. The application currently supports Length, Weight/Mass, and Temperature conversions and is designed with a layered architecture to allow easy extension for additional conversion categories and units in the future.

## Features

* RESTful API endpoint for unit conversion
* Length conversions

  * Meter
  * Foot
  * Kilometer
* Weight conversions

  * Kilogram
  * Pound
* Temperature conversions

  * Celsius
  * Fahrenheit
* Swagger/OpenAPI documentation
* Dependency Injection
* Repository Pattern
* Service Layer Architecture
* Error Handling
* Extensible Design

## Project Structure

```text
UnitConversionApi
│
├── Controllers
│   └── ConversionController.cs
│
├── Models
│   ├── ConversionRequest.cs
│   ├── ConversionResponse.cs
│   ├── UnitDefinition.cs
│   └── ConversionCategory.cs
│
├── Repositories
│   ├── IUnitRepository.cs
│   └── UnitRepository.cs
│
├── Services
│   └── ConversionService.cs
│
├── Program.cs
└── README.md
```

## API Endpoint

### Convert Units

**POST**

```text
/api/conversion
```

### Request Example

```json
{
  "category": "Length",
  "fromUnit": "meter",
  "toUnit": "foot",
  "value": 10
}
```

### Response Example

```json
{
  "inputValue": 10,
  "fromUnit": "meter",
  "toUnit": "foot",
  "result": 32.81
}
```

## Additional Test Cases

### Weight Conversion

Request

```json
{
  "category": "Weight",
  "fromUnit": "kilogram",
  "toUnit": "pound",
  "value": 5
}
```

Response

```json
{
  "inputValue": 5,
  "fromUnit": "kilogram",
  "toUnit": "pound",
  "result": 11.02
}
```

### Temperature Conversion

Request

```json
{
  "category": "Temperature",
  "fromUnit": "celsius",
  "toUnit": "fahrenheit",
  "value": 37
}
```

Response

```json
{
  "inputValue": 37,
  "fromUnit": "celsius",
  "toUnit": "fahrenheit",
  "result": 98.6
}
```

## Running the Project

### Prerequisites

* .NET 8 SDK
* Visual Studio 2022 or Visual Studio Code

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run
```

### Swagger

After running the application, open:

```text
https://localhost:7028/swagger
```

## Design Decisions

### Repository Pattern

Unit definitions are stored in a repository layer. This separates data management from business logic and allows future migration to a database or configuration source.

### Service Layer

All conversion logic is centralized in the service layer, keeping controllers lightweight and maintainable.

### Dependency Injection

ASP.NET Core built-in dependency injection is used to manage dependencies and improve testability.

### Extensibility

Although units are currently hardcoded, the architecture supports future enhancements such as:

* Database-backed unit storage
* Additional conversion categories
* Dynamic unit configuration
* API versioning

## Trade-Offs

For simplicity and to satisfy the assignment scope, conversion factors are hardcoded. In a production environment supporting hundreds of units, a database or configuration-driven approach would be preferred.

## Technologies Used

* ASP.NET Core 8 Web API
* C#
* Swagger / OpenAPI
* Dependency Injection
* Repository Pattern

## Author

Saurabh Kachare
