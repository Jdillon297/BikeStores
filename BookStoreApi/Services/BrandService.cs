using BookStoreApi.Data.Repositories;
using BookStoreApi.Dtos.Brands;
using BookStoreApi.Dtos.Products;
using BookStoreApi.Entities;

namespace BookStoreApi.Services;

public interface IBrandService
{
    IEnumerable<Brand> GetAllBrands();
    Brand GetBrandById(int id);
    int AddBrand(PostBrandDto brand);
    IEnumerable<GetProductDto> GetProductsByBrandId(int id);
}

public sealed class BrandService : IBrandService
{
    private readonly IBrandRepository brandRepository;
    private readonly IProductRepository productRepository;

    public BrandService(IBrandRepository repository, IProductRepository productRepository)
    {
        this.brandRepository = repository;
        this.productRepository = productRepository;
    }

    public IEnumerable<Brand> GetAllBrands()
    {
        return brandRepository.GetAllBrands();
    }

    public Brand GetBrandById(int id)
    {
        return brandRepository.GetBrandById(id);
    }

    public int AddBrand(PostBrandDto dto)
    {
        return this.brandRepository.AddBrand(MapToBrand(dto));
    }

    public IEnumerable<GetProductDto> GetProductsByBrandId(int id)
    {
        var products = this.productRepository.GetAllProducts()
            .Where(p => p.BrandId == id);        
        return MapToProductDtos(products);
    }

    private static Brand MapToBrand(PostBrandDto dto) => new(){ BrandName = dto.BrandName };
    
    private static IEnumerable<GetProductDto> MapToProductDtos(IEnumerable<Product> products) =>
        products.Select(x => new GetProductDto
        {
            ProductId = x.ProductId,
            ListPrice = x.ListPrice,
            ModelYear = x.ModelYear,
            ProductName = x.ProductName,
        });

}
