# Blazor Web App CRUD Server (.NET 9)

A clean, fully functional CRUD application built with the new **Blazor Web App** model in .NET 9.  
This project demonstrates:

- Create, Read, Update, Delete operations  
- EF Core integration  
- Interactive render modes  
- Razor component routing  
- Clean UI with Bootstrap  
- A stable, production-ready CRUD pipeline  

## Features

### ✔ Create Product  
Interactive form with validation and EF Core persistence.

### ✔ Edit Product  
Loads an existing product by ID, updates values, and saves changes.

### ✔ Delete Product  
Confirmation page with safe delete action.

### ✔ Product List  
Displays all products with Edit/Delete actions.

## Architecture Notes

This project uses the new Blazor Web App model, which requires:

- `@rendermode InteractiveServer` for forms  
- Unique `FormName` attributes for `<EditForm>`  
- Clean routing (`@page "/products/create"`, etc.)  
- EF Core DbContext injection via `Program.cs`

## Next Steps

- Add validation  
- Add toast notifications  
- Add sorting/filtering  
- Add pagination  
- Add categories  
- Add authentication  

---

## Milestone

As of this commit, **all CRUD operations are fully functional** and the database is clean.
