using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ProductApi.Models;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    [BsonElement("Name")]
    [JsonPropertyName("Name")]
    public string Name { get; set; } = null!;

    [BsonElement("Price")]
    [JsonPropertyName("Price")]
    public decimal Price { get; set; }

    [BsonElement("Description")]
    [JsonPropertyName("Description")]
    public string Description { get; set; } = null!;

    [BsonElement("Category")]
    [JsonPropertyName("Category")]
    public string Category { get; set; } = null!;

    [BsonElement("Stock")]
    [JsonPropertyName("Stock")]
    public int Stock { get; set; }

    [BsonElement("ImageUrl")]
    [JsonPropertyName("ImageUrl")]
    public string ImageUrl { get; set; } = null!;
}
