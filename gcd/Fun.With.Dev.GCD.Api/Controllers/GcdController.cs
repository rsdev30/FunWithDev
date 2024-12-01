using Fun.With.Dev.GCD.Api;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GcdController : ControllerBase
    {
        private readonly ILogger<GcdController>? _logger;

        public GcdController(ILogger<GcdController>? logger)
        {
            _logger = logger ?? throw new NullReferenceException(nameof(logger));
        }

        /// <summary>
        /// This very first implementation shows the code is coupled to the controller.
        /// TODO: Refactor into a handler or non anemic domain model. 
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetGcdResults")]
        public async Task<ActionResult<GcdResults>> Get(uint M, uint N)
        {
            return await Task.Run<ActionResult<GcdResults>>(() =>
            {
                var result = new GcdResults();

                try
                {

                    uint remainder = 0;
                    result.M = M;
                    result.N = N;
                    result.Gcd = remainder;

                    //Swap if M < N
                    if (M < N)
                    {
                        uint tempM = M;
                        uint tempN = N;

                        M = tempN;
                        N = tempM;

                        result.M = M;
                        result.N = N;
                    }


                    while (N > 0)
                    {
                        remainder = M % N;

                        if (remainder == 0)
                        {
                            result.Gcd = N;
                            break;
                        }

                        M = N;
                        N = remainder;

                    }

                    return result;
                }
                catch (Exception ex)
                {
                    _logger?.LogCritical(ex, "Error calculating GCD.");
                    return BadRequest("Error calculating GCD.");
                }
            });
        }
    }
}