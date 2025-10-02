# Library Portal – Blazor Web App

A web-based library portal built using **Blazor** for managing books, users, and loans.

---

## Features

- User authentication & roles (e.g. Admin, Librarian, Member)  
- CRUD operations on books, categories, authors  
- Issue / return book transactions  
- Search, filtering, pagination  
- Responsive UI using Blazor components  
- API integration layer (to backend services)  
- Configuration via settings (e.g. API endpoints)  

---

## Architecture & Tech Stack

- **Frontend / UI**: Blazor (Server)  
- **Backend / API Layer**: ASP.NET Core Web API  
- **Data / Storage**: QL Server
- **Languages & Tools**:  
  - C# (Blazor, .NET 9.0)  
  - HTML / CSS  
  - JSON for configuration  

---

## Getting Started

### Prerequisites

Before running, ensure you have:

- [.NET SDK 9.0 (or the version your project targets)]  
-  A SQL Server database 
- An IDE or code editor (e.g. Visual Studio, VS Code)  

### Setup & Run

1. Clone this repository:

   ```bash
   git clone https://github.com/rashedulalam46/library-portal-blazor-web-app.git
   cd library-portal-blazor-web-app
   ```
   
Open the solution in your IDE (e.g. LibraryPortalBlazorWebApp.sln).

Configure settings:

In appsettings.json / appsettings.Development.json, update the API endpoint or connection string.

If you have an ApiSettings.cs, adjust base URLs etc.

# Build & run:
```
dotnet build
dotnet run
```

Or run from your IDE with debugging.

Navigate to https://localhost:5001 (or the configured port) in your browser.

# Project Structure

```
/
│
├── Components/        # Reusable Blazor components  
├── Models/            # Data models / DTOs  
├── Pages/             # Blazor pages / routing  
├── Services/           # Services (API clients, business logic)  
├── wwwroot/            # Static assets (css, js, images)  
├── ApiSettings.cs      # Configuration helper  
├── Program.cs          # App startup  
├── Routes.razor         # Routing definitions  
├── LibraryPortalBlazorWebApp.csproj  
├── LibraryPortalBlazorWebApp.sln  
├── appsettings.json  
└── appsettings.Development.json  

```

