﻿using BookStoreApi.Data.Repositories;
using BookStoreApi.Entities;

namespace BookStoreApi.Services.Brands;

public interface IBrandService
{
    IEnumerable<Brand> GetAllBrands();
}

public class BrandService : IBrandService
{
    private readonly IBrandRepository repository;

    public BrandService(IBrandRepository repository)
    {
        this.repository = repository;
    }

    public IEnumerable<Brand> GetAllBrands()
    {
        return repository.GetAllBrands();
    }
}
