using BookStoreApi.Data.Repositories;
using BookStoreApi.Entities;
using BookStoreApi.Services.Brands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService services;
        public BrandsController(IBrandService services)
        {
            this.services = services;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Brand>> GetAllBrands()
        {
            return Ok(this.services.GetAllBrands());
        }
    }
}
