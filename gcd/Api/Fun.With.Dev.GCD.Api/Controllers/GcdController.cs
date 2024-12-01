using Fun.With.Dev.GCD.Api;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.Marshalling;

namespace Fun.With.Dev.GCD.Api.Controllers
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
        /// Adapted from the legendary Dr. Knuth's AOP Series Volume I
        /// https://learning.oreilly.com/library/view/art-of-computer/9780321635754/ch01.xhtml#ch01lev1sec1
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
                    //Step E0
                    if (M < N)
                    {
                        uint tempM = M;
                        uint tempN = N;

                        M = tempN;
                        N = tempM;

                        result.M = M;
                        result.N = N;
                    }

                    //Step E1
                    while (N > 0)
                    {
                        remainder = M % N;

                        //Step E2
                        if (remainder == 0)
                        {
                            result.Gcd = N;
                            break;
                        }
                        
                        //Step E3
                        //Reduce
                        M = N;
                        N = remainder;
                        result.Gcd = remainder;
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