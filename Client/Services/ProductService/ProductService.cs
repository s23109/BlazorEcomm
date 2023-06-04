using BlazorEcomm.Shared;
using System.Net.Http.Json;

namespace BlazorEcomm.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public event Action ProductsChanged;

        public ProductService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProductById(int Id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"/api/Product/{Id}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ? 
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("/api/Product"):
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"/api/Product/Category/{categoryUrl}");
            if (result != null && result.Data != null) Products = result.Data;

            ProductsChanged.Invoke();
        }
    }
}
