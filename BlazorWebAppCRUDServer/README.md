# 02 - Product CRUD Pages

This branch implements the first interactive UI components of the Blazor CRUD application.  
It builds on the EF Core foundation established in the previous branch.

## Goals
- Display a list of products from the database
- Create a new product using a form
- Add navigation links to access CRUD pages
- Use dependency injection to access AppDbContext
- Apply basic validation and error handling

---

## Features Implemented in This Branch

### 1. Products List Page (`Products.razor`)
- Loads products asynchronously from the database
- Displays results in a clean table layout
- Includes navigation to the Create page
- Prepares placeholders for Edit/Delete actions

### 2. Create Product Page (`CreateProduct.razor`)
- Form with Name, Description, Price, and Quantity
- Validation for required fields
- Saves new product to the database
- Redirects back to the Products list

### 3. Navigation Updates
- Adds a “Products” link to the sidebar
- Ensures consistent routing across the app

---

## Next Steps (Future Branches)
- Edit product page
- Delete confirmation page
- UI polish and layout improvements
- Validation enhancements

This branch completes the first half of the CRUD workflow:  
**Create → List**