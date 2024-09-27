using BookStoreApi.Data;
using BookStoreApi.Data.Repositories;
using BookStoreApi.Services;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Extensions;

public static class DependencyInjection
{

    public static IServiceCollection AddDependencyInjection(this IServiceCollection services,WebApplicationBuilder builder)
    {      
        _ = services.ConfigureServices(builder.Configuration);
        return services;

    }

    private static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabaseContext(configuration);

        services.AddScoped<IBrandRepository,BrandRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IStaffRepository, StaffRepository>();
        
        services.AddScoped<IBrandService,BrandService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();  
        services.AddScoped<IStaffService, StaffService>();
        
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
