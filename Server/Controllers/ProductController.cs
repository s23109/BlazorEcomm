using BlazorEcomm.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcomm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service) {
            this._service = service;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            return Ok(await _service.GetProductsAsync());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int Id)
        {
            return Ok(await _service.GetProductByIdAsync(Id));
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductByCategory(string categoryUrl)
        {
            var result = await _service.GetProductsByCategoryAsync(categoryUrl);
            return Ok(result);
        }

    }
}
