namespace SignalRProject.WebUI.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool ProductStatus { get; set; }
        public string ProductDescription { get; set; }
        public Decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public int CategoryId { get; set; }

    }
}
