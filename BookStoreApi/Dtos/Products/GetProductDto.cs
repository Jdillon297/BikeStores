namespace BookStoreApi.Dtos.Products
{
    public class GetProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public short ModelYear { get; set; }

        public decimal ListPrice { get; set; }
    }
}
