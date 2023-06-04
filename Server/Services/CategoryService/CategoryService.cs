using BlazorEcomm.Server.Data;

namespace BlazorEcomm.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly MyDbContext _dbContext;

        public CategoryService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _dbContext.Categories.ToListAsync();

            return new ServiceResponse<List<Category>> { Data=categories };
        }

        public Task<ServiceResponse<Category>> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
