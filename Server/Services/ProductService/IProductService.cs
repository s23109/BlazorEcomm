﻿namespace BlazorEcomm.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductByIdAsync(int Id);

        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);

        Task<ServiceResponse<List<Product>>> SearchProduct(string searchText);

        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
    }
}
