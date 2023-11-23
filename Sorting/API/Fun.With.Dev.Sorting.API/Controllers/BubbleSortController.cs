using Fun.With.Dev.Sorting.Contracts.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Fun.With.Dev.Sorting.API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class BubbleSortController : ControllerBase
    {
        private readonly ILogger<BubbleSortController> _logger;
        private readonly IBubbleSort _sort;
        public BubbleSortController(ILogger<BubbleSortController> logger, IBubbleSort sort)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _sort = sort ?? throw new ArgumentNullException(nameof(sort)); ;
        }

        // POST api/<MergeSortController>
        [HttpPost]
        public int[] Post([FromBody] int[] value)
        {
            try
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                return _sort.Sort(value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sorting");
                throw;
            }
        }
    }
}