# BlazorWebAppCRUDServer

A server‑side Blazor Web App demonstrating a complete CRUD workflow using EF Core, SQL Server, and modern .NET interactive form handling.  
This project serves as a clean, production‑ready foundation for teaching Blazor, EF Core, and full‑stack .NET development.

---

## 🚀 Project Overview

This application is built using:

- **Blazor Web App (Interactive Server)**
- **.NET 8/9**
- **Entity Framework Core**
- **SQL Server / LocalDB**
- **Server‑side form handlers with FormName binding**
- **Razor Components + Layouts**

The goal is to provide a clear, modular, and extensible CRUD example suitable for:

- Curriculum development  
- Tutorials and workshops  
- YouTube walkthroughs  
- Real‑world starter templates  

---

## 📦 Features

- Create, Read, Update, Delete (CRUD) operations  
- EF Core DbContext with SQL Server  
- Server‑side model binding using `FormName`  
- Validation using Data Annotations  
- Clean UI with Bootstrap  
- Modular folder structure for future expansion  

---

## 🗂️ Project Structure
This application is built using:

- **Blazor Web App (Interactive Server)**
- **.NET 8/9**
- **Entity Framework Core**
- **SQL Server / LocalDB**
- **Server‑side form handlers with FormName binding**
- **Razor Components + Layouts**

The goal is to provide a clear, modular, and extensible CRUD example suitable for:

- Curriculum development  
- Tutorials and workshops  
- YouTube walkthroughs  
- Real‑world starter templates  

---

## 📦 Features

- Create, Read, Update, Delete (CRUD) operations  
- EF Core DbContext with SQL Server  
- Server‑side model binding using `FormName`  
- Validation using Data Annotations  
- Clean UI with Bootstrap
- - Modular folder structure for future expansion  

---

## 🗂️ Project Structure
/Components /Pages Products.razor ProductsCreate.razor ProductsEdit.razor ProductsDelete.razor /Data AppDbContext.cs /Models Product.cs

This structure aligns with the modern Blazor Web App architecture.

---

## 🛠️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/<yourname>/BlazorWebAppCRUDServer.git
cd BlazorWebAppCRUDServer
2. Update the connection string
In appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BlazorWebAppCRUDServer;Trusted_Connection=True;"
}

3. Apply EF Core migrations
dotnet ef migrations add InitialCreate
dotnet ef database update
4. Run the application

dotnet run
Navigate to:
https://localhost:xxxx/products










