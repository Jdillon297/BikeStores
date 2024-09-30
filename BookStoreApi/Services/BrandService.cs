using BookStoreApi.Data.Repositories;
using BookStoreApi.Dtos.Brands;
using BookStoreApi.Entities;

namespace BookStoreApi.Services;

public interface IBrandService
{
    IEnumerable<Brand> GetAllBrands();
    Brand GetBrandById(int id);
    int AddBrand(PostBrandDto brand);
}

public sealed class BrandService : IBrandService
{
    private readonly IBrandRepository repository;

    public BrandService(IBrandRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Brand> GetAllBrands()
    {
        return repository.GetAllBrands();
    }

    public Brand GetBrandById(int id)
    {
        return repository.GetBrandById(id);
    }

    public int AddBrand(PostBrandDto dto)
    {
        return this.repository.AddBrand(MapToBrand(dto));
    }


    private static Brand MapToBrand(PostBrandDto dto)
    {
        return new Brand
        {
            BrandName = dto.BrandName,
        };
    }
}
