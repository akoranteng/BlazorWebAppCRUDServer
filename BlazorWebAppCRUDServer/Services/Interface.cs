using BlazorWebAppCRUDServer.Models;




namespace BlazorWebAppCRUDServer.Services;

public interface IProductService
{
    Task<List<Product>> GetProductsAsync(string sortBy, string direction, int page, int pageSize);
    Task<int> GetTotalCountAsync();
    Task<Product?> GetProductByIdAsync(int id);
    Task<Product> CreateProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);
    Task<bool> DeleteProductAsync(int id);
}
