📘 EF Core Setup — Branch 01-efcore-setup
🎯 Purpose of This Branch
This branch establishes the data foundation for the Blazor Web App CRUD project.
It introduces Entity Framework Core, configures the database connection, defines the domain model, and prepares the project for database migrations.
This is the first major milestone in the curriculum and sets the stage for CRUD operations in the next branch.

✅ What Was Implemented in This Branch
1. EF Core Packages Installed
Stable .NET 9–compatible EF Core packages were added:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- - Microsoft.EntityFrameworkCore.Tools
These were pinned to avoid preview version conflicts

2. Connection String Added
Configured LocalDB for easy inspection in Visual Studio’s Server Explorer:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BlazorCRUD;Trusted_Connection=True;"
}

This ensures a friction‑free development and teaching experience.
3. Domain Model Created
Models/Product.cs defines the core entity for this module:
- Id — primary key
- Name — product name
- Price — decimal with precision (18,2)
This model will be used throughout the CRUD workflow
- 
- 4. AppDbContext Added
Data/AppDbContext.cs includes:
- DbSet<Product> for EF Core tracking
- Decimal precision configuration for Price
- A clean, minimal EF Core context aligned with .NET 9 patterns

5. EF Core Registered in Program.cs
The DbContext is registered using the minimal hosting model:

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

6. Project Builds Cleanly
All namespaces, folders, and references were aligned:
- /Models folder
- /Data folder
- Correct namespaces
- Clean Program.cs
- No build errors
This ensures a stable foundation for migrations.

🧪 Next Step: Run the Initial Migration
Once this branch is committed and pushed, run the following in Package Manager Console:
Add-Migration InitialCreate
Update-Database

This will create:
- BlazorCRUD database
- Products table
- __EFMigrationsHistory table







