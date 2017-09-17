using System;
using System.Threading.Tasks;
using InvestorAPI.Configuration;
using InvestorAPI.Interface;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace InvestorAPI.data
{
    public class InvestorRepository : IInvestorRepository
    {
        private readonly InvestorContext _context = null;

        public InvestorRepository(IOptions<Settings> settings)
        {
			_context = new InvestorContext(settings);
        }

        public string GetAllInvestor()
		{
            return _context.Investor.Find(new BsonDocument()).ToList().ToJson();
		}
    }
}
