using Subscriber.Models;
using System;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using Subscriber.Settings;

namespace Subscriber.Services.Implementation
{
    class MongoDBService : IDBService
    {
        private readonly IMongoCollection<Car> _collection;

        public MongoDBService(IDBSettings settings)
        {

            var client = new MongoClient(settings.ConnectionString);

            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<Car>(settings.CollectionName);
        }

        public async Task<string> InsertSingleRecord(Car car)
        {
            await _collection.InsertOneAsync(car);

            return car.ID.ToString();
        }
    }
}
