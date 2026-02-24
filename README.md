## Summary

Results-oriented **.NET developer** with experience building clean, layered **ASP.NET Core Web APIs** using **Entity Framework Core** and SQL Server. Comfortable designing RESTful endpoints, implementing business logic and data access layers, and adding cross-cutting concerns such as logging and centralized error handling. Strong focus on readable code, separation of concerns, and learning modern best practices in the .NET ecosystem.

---

## Skills

- **Languages**: C#, SQL
- **Frameworks**: ASP.NET Core, .NET 6/7/8
- **Data & ORM**: Entity Framework Core, LINQ, SQL Server (LocalDB / full SQL Server)
- **Web & APIs**: RESTful APIs, Swagger / OpenAPI, JSON
- **Architecture**: Layered architecture (Controller → Service → Repository → DbContext), Dependency Injection, Middleware
- **Tools**: Visual Studio / VS Code, Git, dotnet CLI

---

## Projects

### Employee Management API (ASP.NET Core 8, EF Core, SQL Server)
- Built a **clean, layered CRUD Web API** to manage employee records (create, read, update, delete).
- Designed an **`Employee` domain model** and configured EF Core with a SQL Server database and migrations.
- Implemented a **repository layer** for data access and a **service layer** for business logic and validation (e.g., required fields, salary rules).
- Added **custom middleware** for:
  - Centralized exception handling, returning consistent JSON error responses.
  - Request logging with execution time for each HTTP request.
- Exposed a REST API via an `EmployeesController` with endpoints:
  - `GET /api/employees`
  - `GET /api/employees/{id}`
  - `POST /api/employees`
  - `PUT /api/employees/{id}`
  - `DELETE /api/employees/{id}`
- Enabled **Swagger / OpenAPI** for interactive documentation and testing of all endpoints.


