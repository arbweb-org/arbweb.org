using Microsoft.AspNetCore.Mvc;

namespace arbweb_api.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class weather : ControllerBase
    {
        [HttpGet("integer")]
        public int get_integer()
        {
            return 123;
        }

        [HttpGet("string")]
        public string get_string()
        {
            return "Hello you!";
        }
    }
}