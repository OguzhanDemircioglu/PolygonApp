using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace PolygonApp.Models
{
    public class Polygon
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [JsonIgnore]
        public string? Id { get; set; }
        public List<Coordinate>? list{ get; set; } = null;
        public string? username { get; set; } = null;
        public string? number { get; set; } = null;
    }
}
