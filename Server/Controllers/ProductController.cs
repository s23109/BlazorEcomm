using BlazorEcomm.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcomm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _context;
        
        public ProductController(MyDbContext dbContext) {
            this._context = dbContext;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var Products = await _context.Products.ToListAsync();
            return Ok(Products);
        }

    }
}
