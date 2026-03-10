Milestone 10 — Sorting & Pagination for Products List
This milestone transforms the Products list from a static table into a fully interactive, user‑friendly component with sorting, pagination, and a clean architectural pattern for future list pages. It also reinforces best practices for Razor component structure, centralized data loading, and UI‑driven state management.
🚀 Features Added
1. Centralized Data Loading
All product retrieval now flows through a single LoadProducts() method, ensuring consistent behavior across:
- Sorting
- Pagination
- Initial page load
2. Column Sorting
Users can sort by:
- Name
- Description
- Price
- Quantity
Sorting includes:
- Ascending / descending toggle
- Visual indicators (▲ ▼ ↕)
- - Auto‑reset to page 1 when sorting changes
3. Pagination
The Products list now supports:
- Next / Previous navigation
- Page X of Y display
- Automatic disabling of buttons on first/last pages
- Full integration with sorting
Sorting Logic
SortBy(column):
- Toggles direction when clicking the same column
- Resets to ascending when switching columns
- Resets to page 1
- Calls LoadProducts()
Pagination Helpers

- private int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
private bool IsFirstPage => CurrentPage == 1;
private bool IsLastPage => CurrentPage == TotalPages;
- private async Task NextPage() { ... }
private async Task PreviousPage() { ... }
UI Enhancements
- Sorting buttons added to table headers
- Pagination controls added below the table

📁 Files Updated
- Pages/Products/ProductList.razor
- Added sorting UI
- Added pagination UI
- Added centralized loader
- Added sorting + pagination logic
- Cleaned up component structure
- ⚠️ Gotchas & Lessons Learned
- Razor components break easily when methods fall outside the @code block.
- A stray { or } can cause the entire page to “disappear.”
- Keeping all logic inside a single, well‑structured @code block prevents structural errors.
- Centralizing data loading (LoadProducts()) dramatically simplifies UI behavior.
🧪 Testing Steps
- Load /products
- Verify initial list loads
- Click each column header
- Sorting toggles correctly
- Indicators update
- Click Next
- Page increments
- Table updates
- Click Previous
- - Page decrements
- Verify buttons disable on first/last pages
- Combine sorting + pagination
- Sorting resets to page 1
- Pagination still works
- 📚 Next Steps
- Add a Page Size dropdown (5, 10, 20, 50)
- Add numbered page buttons (1, 2, 3…)
- Add First / Last navigation
- Begin preparing curriculum slides for Sorting + Pagination
