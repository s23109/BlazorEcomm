using BlazorEcomm.Shared;

namespace BlazorEcomm.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        string Message { get; set; }
        Task<ServiceResponse<Product>> GetProductById(int Id);
        Task SearchProduct(string searchText);
        Task<List<string>> GetProductSearchSuggestions(string searchText);
    }
}
