using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GraphQLService.Schema;
namespace GraphQLService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public AccountController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            var accounts = new List<Account>{
            new Account {
                Code = "1",
                Name = "Banks",
                Level = 1,
            },
            new Account {
                Code = "2",
                Name = "Suppliers",
                Level = 1,
            }
        };
            return accounts;
        }

        [HttpPost]
        public Account Post(Account account)
        {
            return account;
        }
    }
}
