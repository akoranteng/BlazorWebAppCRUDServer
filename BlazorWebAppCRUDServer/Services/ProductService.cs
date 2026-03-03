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

        public async Task<List<Product>> GetProductsAsync(string sortBy, string sortDirection)
        {
            IQueryable<Product> query = _context.Products;

            query = (sortBy, sortDirection) switch
            {
                ("Name", "asc") => query.OrderBy(p => p.Name),
                ("Name", "desc") => query.OrderByDescending(p => p.Name),

                ("Description", "asc") => query.OrderBy(p => p.Description),
                ("Description", "desc") => query.OrderByDescending(p => p.Description),

                ("Price", "asc") => query.OrderBy(p => p.Price),
                ("Price", "desc") => query.OrderByDescending(p => p.Price),

                ("Quantity", "asc") => query.OrderBy(p => p.Quantity),
                ("Quantity", "desc") => query.OrderByDescending(p => p.Quantity),

                _ => query.OrderBy(p => p.Id)
            };

            return await query.ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is not null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }


    }
}