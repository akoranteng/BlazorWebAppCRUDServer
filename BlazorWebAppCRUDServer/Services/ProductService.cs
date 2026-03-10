using BlazorWebAppCRUDServer.Data;
using BlazorWebAppCRUDServer.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppCRUDServer.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        // ---------------------------------------------------------
        // PAGINATED + SORTED PRODUCT LIST
        // ---------------------------------------------------------
        public async Task<List<Product>> GetProductsAsync(
            string sortBy,
            string direction,
            int page,
            int pageSize)
        {
            var query = _context.Products.AsQueryable();

            // Sorting logic
            query = sortBy switch
            {
                "Name" => direction == "asc"
                    ? query.OrderBy(p => p.Name)
                    : query.OrderByDescending(p => p.Name),

                "Description" => direction == "asc"
                    ? query.OrderBy(p => p.Description)
                    : query.OrderByDescending(p => p.Description),

                "Price" => direction == "asc"
                    ? query.OrderBy(p => p.Price)
                    : query.OrderByDescending(p => p.Price),

                "Quantity" => direction == "asc"
                    ? query.OrderBy(p => p.Quantity)
                    : query.OrderByDescending(p => p.Quantity),

                _ => query
            };

            // Pagination
            return await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        // ---------------------------------------------------------
        // TOTAL COUNT (for pagination)
        // ---------------------------------------------------------
        public async Task<int> GetTotalCountAsync()
        {
            return await _context.Products.CountAsync();
        }

        // ---------------------------------------------------------
        // CRUD OPERATIONS
        // ---------------------------------------------------------
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}