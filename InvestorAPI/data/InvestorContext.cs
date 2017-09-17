using System;
using InvestorAPI.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InvestorAPI.data
{
    public class InvestorContext
    {
        private readonly IMongoDatabase _database = null;

        public InvestorContext(IOptions<Settings> settings)
        {
			var client = new MongoClient(settings.Value.ConnectionString);
			if (client != null)
				_database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<BsonDocument> Investor
		{
			get
			{
				return _database.GetCollection<BsonDocument>("investor");
			}
		}
    }
}
