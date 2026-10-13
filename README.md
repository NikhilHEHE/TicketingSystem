# Ticketing System with CQRS

A commercial-level ticketing system backend built with .NET 8 using the CQRS pattern and MediatR library.

## Features

- **CQRS Implementation**: Uses MediatR for clean separation of concerns
- **Two Query Endpoints**:
  - `GET /api/tickets/date-range?startDate=&endDate=` - Find tickets based on date range
  - `GET /api/tickets/{id}` - Find a specific ticket by ID
- **Data Access**: Entity Framework Core with SQL Server
- **API Documentation**: Swagger/OpenAPI integration
- **DTO Pattern**: Clean separation between internal models and API responses
- **Commercial Standard**: Follows best practices for maintainable, scalable code

## Requirements Met

✅ Created a ticketing system using CQRS  
✅ Implemented two endpoints:
   - To find tickets based on date range
   - To find a specific ticket for a given id  
✅ Implemented it like commercial standard  
✅ Used SQL Server DB  
✅ No authentication (as specified)  
✅ No UI frontend (as specified)  

## Technology Stack

- .NET 8 Web API
- MediatR (for CQRS)
- Entity Framework Core (with SQL Server provider)
- Swashbuckle (for Swagger/OpenAPI)
- C# 12

## Project Structure

```
TicketingSystem/
├── Controllers/          # API controllers
├── Data/                 # Database context
├── Dtos/                 # Data transfer objects
├── Models/               # Entity models
├── Queries/              # CQRS queries and handlers
├── appsettings.json      # Configuration
└── TicketingSystem.csproj # Project file
```

## Setup and Running

1. Ensure you have .NET 8 SDK installed
2. Update the connection string in `appsettings.json` if needed
3. Run `dotnet run` to start the application
4. Access Swagger UI at `http://localhost:{port}/swagger` to test endpoints

## API Endpoints

### Get Tickets by Date Range
```
GET /api/tickets/date-range?startDate=2026-01-01&endDate=2026-12-31
```
Returns: Array of TicketDto objects (empty array if no matches)

### Get Ticket by ID
```
GET /api/tickets/123
```
Returns: Single TicketDto object or 404 if not found

## CQRS Implementation

Each query follows the CQRS pattern:
- Query record (e.g., `GetTicketsByDateRangeQuery`)
- Query handler (e.g., `GetTicketsByDateRangeQueryHandler`)
- MediatR mediates between controller and handler

## Data Model

The Ticket entity includes:
- Id (Primary Key)
- Title (Required, max 200 chars)
- Description (Required, max 1000 chars)
- CreatedDate (Required)
- UpdatedDate (Optional)

## Notes

- The application uses environment-specific configuration
- Connection string can be overridden via environment variables for deployment
- Designed for easy extension with additional queries/commands
- Follows RESTful API conventions