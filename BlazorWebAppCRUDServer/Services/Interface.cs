using BlazorWebAppCRUDServer.Models;




namespace BlazorWebAppCRUDServer.Services;

public interface IProductService
{
    Task<List<Product>> GetProductsAsync(string sortBy, string sortDirection);
    Task<Product?> GetProductByIdAsync(int id);
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
}
