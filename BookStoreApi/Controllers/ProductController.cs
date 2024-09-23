using BookStoreApi.Entities;
using BookStoreApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(this.service.GetAllProducts());
        }

        [HttpGet]
        [Route("GetByCategory{categoryId}")]
        public ActionResult<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            return Ok(this.service.GetProductsByCategoryId(categoryId));
        }
    }
}
