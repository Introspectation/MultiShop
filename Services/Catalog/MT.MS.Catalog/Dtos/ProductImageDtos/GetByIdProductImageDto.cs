namespace MT.MS.Catalog.Dtos.ProductImageDtos
{
    public class GetByIdProductImageDto
    {
        public string ProductImageId { get; set; }
        public List<string> ImageUrls { get; set; }
        public string ProductId { get; set; }
    }
}
