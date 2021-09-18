using FunWith.Palindromes.Manager.Strategies.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FunWIth.Palindromes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalindromeController : ControllerBase
    {      
        private readonly ILogger<PalindromeController> _logger;
        private readonly PalindromeContext _palindromeContext;

        public PalindromeController(ILogger<PalindromeController> logger, PalindromeContext palindromeContext)
        {
            _logger = logger;
            _palindromeContext = palindromeContext;
        }

        [HttpGet]
        public bool GetIsPalindrome(string word = "")
        {
            return _palindromeContext.IsPalindrome(word ?? string.Empty);
        }
    }
}
