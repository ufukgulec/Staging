using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Staging.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;

        public EnvironmentController(IWebHostEnvironment env, IConfiguration config)
        {
            _env = env;
            _config = config;
        }

        [HttpGet]
        public IActionResult GetEnvironment()
        {
            return Ok(new
            {
                Environment = _env.EnvironmentName,
                ConnectionString = _config.GetConnectionString("DefaultConnection")
            });
        }
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok(new
            {
                Environment = _env.EnvironmentName,
                ConnectionString = _config.GetConnectionString("DefaultConnection")
            });
        }
        [HttpGet("hello2")]
        public IActionResult Hello2()
        {
            return Ok(new
            {
                Environment = _env.EnvironmentName,
                ConnectionString = _config.GetConnectionString("DefaultConnection")
            });
        }
    }

}
