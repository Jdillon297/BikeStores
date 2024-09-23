using BookStoreApi.Entities;

namespace BookStoreApi.Data.Repositories;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAllCategories();
}

public class CategoryRepository : ICategoryRepository
{
    private readonly BikeStoresContext context;

    public CategoryRepository(BikeStoresContext context)
    {
        this.context = context;
    }

    public IEnumerable<Category> GetAllCategories()
    {
        return this.context.Categories.ToList();
    }
}
