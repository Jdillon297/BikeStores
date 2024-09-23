using BookStoreApi.Entities;
using BookStoreApi.Data.Repositories;

namespace BookStoreApi.Services;

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
