using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Fun.With.Dev.Sorting.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class BubbleSortController : ControllerBase
    {        
        private readonly ILogger<BubbleSortController> _logger;

        public BubbleSortController(ILogger<BubbleSortController> logger)
        {
            _logger = logger;
        }

        // POST api/<MergeSortController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return value?.OrderBy(x => x)?.ToString() ?? string.Empty;
        }
    }
}