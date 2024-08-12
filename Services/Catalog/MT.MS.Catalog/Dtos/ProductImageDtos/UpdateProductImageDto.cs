namespace MT.MS.Catalog.Dtos.ProductImageDtos
{
    public class UpdateProductImageDto
    {
        public string ProductImageId { get; set; }
        public List<string> ImageUrls { get; set; }
        public string ProductId { get; set; }
    }
}
