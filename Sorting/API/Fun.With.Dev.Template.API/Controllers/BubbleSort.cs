using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Fun.With.Dev.Template.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class BubbleSort : ControllerBase
    {        
        private readonly ILogger<BubbleSort> _logger;

        public BubbleSort(ILogger<BubbleSort> logger)
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