using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fun.With.Dev.Sorting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectionSortController : ControllerBase
    {
        // POST api/<MergeSortController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return value?.OrderBy(x => x)?.ToString() ?? string.Empty;
        }
    }
}
