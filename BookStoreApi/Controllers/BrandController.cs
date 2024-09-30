using BookStoreApi.Dtos.Brands;
using BookStoreApi.Entities;
using BookStoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService services;
        public BrandController(IBrandService services)
        {
            this.services = services;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Brand>> GetAllBrands()
        {
            return Ok(MapToBrandDtos(this.services.GetAllBrands()));
        }

        [HttpGet("{id}")]
        public ActionResult<Brand> GetBrandById(int id)
        {            
            return Ok(this.services.GetBrandById(id));
        }

        [HttpPatch]
        public ActionResult<Brand> UpdateBrandAttribute(int id, Brand brand)
        {
            return Ok();
        }


        [HttpPut]
        public ActionResult<Brand> Update(int id, Brand brand)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<int> CreateBrand(PostBrandDto dto)
        {
            this.services.AddBrand(dto);
            return StatusCodes.Status201Created;            
        }

        [HttpDelete]
        public ActionResult<int> DeleteBrand(int id)
        {
            return StatusCodes.Status200OK;
        }

        private IEnumerable<GetBrandDto> MapToBrandDtos(IEnumerable<Brand> brands)
        {
                return brands.Select(brand => new GetBrandDto
                {
                    Id = brand.BrandId,
                    BrandName = brand.BrandName,

                });
                        
        }
    }
}
