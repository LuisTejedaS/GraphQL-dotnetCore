
using Microsoft.AspNetCore.Mvc;

namespace GraphQLService.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {

        public HomeController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return "hello world go to /graphql/playground";
        }
    }
}
