using BookStoreApi.Entities;

namespace BookStoreApi.Data.Repositories;

public interface IBrandRepository
{
    IEnumerable<Brand> GetAllBrands();  
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
}
