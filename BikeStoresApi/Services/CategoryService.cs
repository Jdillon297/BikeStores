using BikeStoresApi.Entities;
using BikeStoresApi.Data.Repositories;

namespace BikeStoresApi.Services;

public interface ICategoryService
{
    IEnumerable<Category> GetAllCategories();
}

public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository repository;
    public CategoryService(ICategoryRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Category> GetAllCategories()
    {
        return repository.GetAllCategories();
    }
}
