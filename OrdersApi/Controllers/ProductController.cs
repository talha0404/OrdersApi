using Microsoft.AspNetCore.Mvc;
using OrdersApi.Models;

namespace OrdersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            try
            {
                var products = new List<Product>() {
                new Product { Id = 1, CategoryId = 1 , Name = "Shoes", Price = 10.02},
                new Product { Id = 2, CategoryId = 1 , Name = "Dresses", Price = 12.43},
                new Product { Id = 3, CategoryId = 1 , Name = "Hats", Price = 12.66}
            };

                if (products == null || !products.Any())
                {
                    return NotFound("No Products Found");
                }

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
