# Uses the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

# Sets the working directory inside the container
WORKDIR /app

# Copies the entire source code into the container
COPY ./src ./src

# Restores dependencies and builds the application
RUN dotnet publish ./src/BracketValidatorApp.csproj -c Release -o /app/publish

# Uses the official .NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

# Sets the working directory inside the container
WORKDIR /app

# Copies the published output from the build stage
COPY --from=build /app/publish .

# Sets the entry point to the compiled application
ENTRYPOINT ["dotnet", "BracketValidatorApp.dll"]
