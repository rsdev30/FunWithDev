using Fun.With.Dev.Sorting.Contracts.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Fun.With.Dev.Sorting.API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]    
    public class BubbleSortController : ControllerBase
    {
        private readonly ILogger<BubbleSortController> _logger;
        private readonly IBubbleSort<IList<int>, IList<int>> _sort;
        public BubbleSortController(ILogger<BubbleSortController> logger, IBubbleSort<IList<int>, IList<int>> sort)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _sort = sort ?? throw new ArgumentNullException(nameof(sort)); ;
        }
        
        [HttpPost]
        public async Task<IList<int>> Post([FromBody] int[] value)
        {
            try
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                return await _sort.Sort(value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sorting");
                throw;
            }
        }
    }
}