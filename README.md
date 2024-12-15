# Overview

Checks if a given string has matching brackets. It supports various types of brackets including `()`, `{}`, `[]`, and `<>`. The app can be used via a console interface, and can be built and run using Docker.

## Project Structure

```bash
BracketValidatorApp/
│
├── src/
│   └── BracketValidatorApp.csproj          # Main application project
│   └── Program.cs                          # Program entry point
│   └── BracketMatcher.cs                   # Bracket validation logic
│
├── Tests/
│   └── BracketValidatorApp.Tests.csproj    # Test project
│   └── BracketMatcherTests.cs              # Unit tests for bracket validation
│
├── .gitignore                              # Git ignore file to exclude unnecessary files
├── BracketValidatorApp.sln                 # Solution file
├── Dockerfile                              # Docker Image
├── README.md                               # Project README
```

## Features

- Validates matching pairs of brackets.
- Supports multiple types of brackets: `()`, `{}`, `[]`, and `<>`.
- Handles strings with mixed characters, ensuring only brackets are checked.
- Handles null or blank input
- Outputs whether the brackets in the string are correctly matched or mismatched.

## Installation

1. Clone the repository:
```bash
git clone https://github.com/crunchmasterdeluxe/BracketValidatorApp.git
cd BracketValidatorApp
```

2. Restore the NuGet packages:
```bash
dotnet restore
```

3. Build the project:
```bash
dotnet build
```

## Usage

Run the application via the command line:
```bash 
dotnet run --project src
```

### Timekeeping

The program file keeps track of time to measure program efficiency. The ellapsed time is logged each time the BracketMatcher's `HasMatchingBrackets` method is called.

### Example

```bash
Enter a string to check for matching brackets:
<{[()]}>

Time taken to check brackets: 10 ms
👍 Brackets are correctly matched.
```

## Docker

Alternatively, you can run the application with Docker. Docker is included in this application in order to future-proof this application, streamlining setup, portability, and deployment. 

To build the app using Docker, ensure Docker Desktop is open and run the following in the console:

```bash
docker build -t bracket-validator-app .
```

Then, run the image interactively using the following command:
```bash
docker run -it bracket-validator-app
```

## Running Tests

This project uses NUnit for unit testing. To run the tests, use the following command:
```bash
dotnet test
```

The tests are located in the Tests directory and check various edge cases, such as:

- Single pair of brackets.
- Nested brackets.
- Incorrectly matched brackets.
- Brackets with non-bracket characters.
- Empty strings.

## .gitignore

The project includes a .gitignore file to exclude build outputs (bin/, obj/), IDE configuration files, and other unnecessary files from being committed to the repository.

## Dependencies

- .NET 9.0 (or later)
- NUnit 3.x
- NUnit3TestAdapter
- Microsoft.NET.Test.Sdk
