using BlazorEcomm.Server.Data;

namespace BlazorEcomm.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly MyDbContext _dbContext;
        public ProductService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _dbContext.Products.ToListAsync()
            };

            return response;
        }
    }
}
