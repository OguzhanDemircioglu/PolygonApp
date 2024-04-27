using MongoDB.Bson.Serialization.Attributes;

namespace PolygonApp.Models
{
    public class Polygon
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public List<Coordinate>? list{ get; set; } = null;
        public string? username { get; set; } = null;
    }
}
