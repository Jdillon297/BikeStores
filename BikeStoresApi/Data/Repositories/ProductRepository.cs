using BikeStoresApi.Dtos.Products;
using BikeStoresApi.Entities;

namespace BikeStoresApi.Data.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProductsByCategory(int categoryId);
    IEnumerable<Product> GetAllProducts();
}

public class ProductRepository : IProductRepository
{
    private readonly BikeStoresContext context;

    public ProductRepository(BikeStoresContext context)
    {
        this.context = context;
    }
    public IEnumerable<Product> GetAllProducts()
    {
        return this.context.Products.ToList();
    }

    public IEnumerable<Product> GetAllProductsByCategory(int categoryId)
    {
        var products = this.context.Products
            .Where(p => p.CategoryId == categoryId)
            .ToList();
        return products;
    }
}
