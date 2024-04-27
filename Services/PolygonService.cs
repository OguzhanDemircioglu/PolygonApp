using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PolygonApp.Models;

namespace PolygonApp.Services
{
    public class PolygonService
    {
        private readonly IMongoCollection<Polygon> _polygons;

        public PolygonService(IOptions<MongoSettings> mongoDbSettings)
        {
            MongoClient mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionURI);
            IMongoDatabase database = mongoClient.GetDatabase(mongoDbSettings.Value.DataBase);
            _polygons = database.GetCollection<Polygon>(mongoDbSettings.Value.CollectionName);
        }

        public async Task CreateAsync(Polygon polygon)
        {
            await _polygons.InsertOneAsync(polygon);
        }

        public async Task<List<Polygon>> GetAsync()
        {
            return await _polygons.Find(new BsonDocument()).ToListAsync();
        }
    }
}
