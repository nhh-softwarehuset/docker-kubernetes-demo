using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hello_dotnet_core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CakeController : ControllerBase
    {

        private readonly ILogger<CakeController> logger;

        public CakeController(ILogger<CakeController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult GetCakeConclusion()
        {
            return Ok(new CakeResult()
            {
                Title = "Who Provides cake today?",
                Conclusion = "Morten Storm"
            });
        }
    }
}