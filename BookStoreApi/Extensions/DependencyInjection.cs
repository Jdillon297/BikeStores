using BookStoreApi.Data;
using BookStoreApi.Data.Repositories;
using BookStoreApi.Services;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Extensions;

public static class DependencyInjection
{

    public static IServiceCollection AddDependencyInjection(this IServiceCollection services,WebApplicationBuilder builder)
    {
       _ = services.AddDatabaseContext(builder.Configuration);
        _ = services.ConfigureServices();
        return services;

    }

    private static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IBrandRepository,BrandRepository>();
        services.AddScoped<IBrandService,BrandService>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductService, ProductService>();  
        return services;
    }

    private static IServiceCollection AddDatabaseContext(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BikeStoresContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("BikeStore"));
        });
        return services;
    }

}
