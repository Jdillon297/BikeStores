using BookStoreApi.Data.Repositories;
using BookStoreApi.Entities;

namespace BookStoreApi.Services;

public interface IBrandService
{
    IEnumerable<Brand> GetAllBrands();
    Brand GetBrandById(int id);
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
}
