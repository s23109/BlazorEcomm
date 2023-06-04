using BlazorEcomm.Shared;

namespace BlazorEcomm.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);

        Task<ServiceResponse<Product>> GetProductById(int Id);
    }
}
