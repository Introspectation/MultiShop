using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MT.MS.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductImageId { get; set; }

        public List<string> ImageUrls { get; set; }

        public string ProductId { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }
    }
}
