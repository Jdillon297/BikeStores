using BookStoreApi.Entities;

namespace BookStoreApi.Data.Repositories;

public interface IBrandRepository
{
    IEnumerable<Brand> GetAllBrands();
    Brand GetBrandById(int id);
}

public class BrandRepository : IBrandRepository
{
    private readonly BikeStoresContext context;

    public BrandRepository(BikeStoresContext context)
    {
        this.context = context;
    }

    public IEnumerable<Brand> GetAllBrands()
    {
        return this.context.Brands.ToList();
    }

    public Brand GetBrandById(int id)
    {
        return this.context.Brands.Find(id);
    }
}
