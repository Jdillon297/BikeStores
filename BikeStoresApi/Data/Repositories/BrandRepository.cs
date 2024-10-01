using BookStoreApi.Entities;

namespace BookStoreApi.Data.Repositories;

public interface IBrandRepository
{
    IEnumerable<Brand> GetAllBrands();
    Brand GetBrandById(int id);
    int AddBrand(Brand brand);
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

    public int AddBrand(Brand brand)
    {
        this.context.Brands.Add(brand);
        return this.context.SaveChanges();
    } 
}
