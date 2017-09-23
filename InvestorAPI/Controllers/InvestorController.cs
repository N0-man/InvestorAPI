using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestorAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace InvestorAPI.Controllers
{
    [Route("api/[controller]")]
    public class InvestorController : Controller
    {
        //Interface may not be needed for DI
        private readonly IInvestorRepository _investorRepository;

        public InvestorController(IInvestorRepository investorRepository)
        {
            _investorRepository = investorRepository;
        }

		[HttpGet("all")]
        public string Get()
		{
            return  _investorRepository.GetAllInvestor(); ;
		}
    }
}
