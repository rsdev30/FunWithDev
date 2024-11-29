using Fun.With.Dev.GCD.Api;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GcdController : ControllerBase
    {         
        private readonly ILogger<GcdController> _logger;

        public GcdController(ILogger<GcdController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGcdResults")]
        public GcdResults Get(uint M, uint N)
        {
            var results = new GcdResults(); 

            while (N > 0) 
            {

            }

            return results;
        }
    }
}
