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
            var product = await _dbContext.Products.Include(p => p.Variants).ThenInclude(v => v.ProductType).FirstOrDefaultAsync( p => p.Id == Id);

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
                Data = await _dbContext.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var products = await _dbContext.Products.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).Include(p => p.Variants).ToListAsync();
            var response = new ServiceResponse<List<Product>>(){
                Data = products
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> SearchProduct(string searchText)
        {
            //both title and desc check 
            var response = new ServiceResponse<List<Product>> {
                Data = await _dbContext.Products.Where(p => p.Title.ToLower().Contains(searchText.ToLower())
                || p.Description.ToLower().Contains(searchText.ToLower()))
                .Include(p => p.Variants)
                .ToListAsync()
            };

            return response;
        }
    }
}
