using BookStoreApi.Data;
using BookStoreApi.Data.Repositories;
using BookStoreApi.Services.Brands;
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
        services.AddScoped<IBrandService,BrandService>();
        services.AddScoped<IBrandRepository,BrandRepository>();
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
