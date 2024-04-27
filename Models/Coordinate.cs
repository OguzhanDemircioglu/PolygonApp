using MongoDB.Bson.Serialization.Attributes;

namespace PolygonApp.Models
{
    public class Coordinate
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; } = null;
        public double? Latitude { get; set;} = null;
        public double? Longitude { get; set;} =null;
    }
}
