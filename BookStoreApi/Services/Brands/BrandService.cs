using BookStoreApi.Data.Repositories;
using BookStoreApi.Entities;

namespace BookStoreApi.Services.Brands;

public interface IBrandService
{
    IEnumerable<Brand> GetAllBrands();
    Brand GetBrandById(int id);
}

public class BrandService : IBrandService
{
    private readonly IBrandRepository repository;

    public BrandService(IBrandRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Brand> GetAllBrands()
    {
        return this.repository.GetAllBrands();
    }

    public Brand GetBrandById(int id)
    {
        return this.repository.GetBrandById(id);
    }
}
