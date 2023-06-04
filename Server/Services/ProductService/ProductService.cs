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

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int Id)
        {
            var response = new ServiceResponse<Product>();
            var product = await _dbContext.Products.FindAsync(Id);

            if (product == null)
            {
                response.Success= false;
                response.Message = "Product does not exist";
            }
            else
            {
                response.Data = product;
            }

            return response;

        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _dbContext.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var products = await _dbContext.Products.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync();
            var response = new ServiceResponse<List<Product>>(){
                Data = products
            };

            return response;
        }
    }
}
