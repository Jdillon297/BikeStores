﻿using BikeStoresApi.Data.Repositories;
using BikeStoresApi.Entities;

namespace BikeStoresApi.Services;

public interface IProductService
{
    IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    IEnumerable<Product> GetAllProducts();
}

public sealed class ProductService : IProductService
{
    private readonly IProductRepository repository;

    public ProductService(IProductRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Product> GetAllProducts()
    {
       return this.repository.GetAllProducts();
    }

    public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
    {
        return this.repository.GetAllProductsByCategory(categoryId);
    }
}
