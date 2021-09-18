using Fun.With.Dev.Palindromes.Contracts;
using System;
using System.Linq;

namespace Fun.With.Dev.Palindromes.Manager.Strategies
{
    public class CheckPalindromeReverseMethod : IPalindromeInputCheck<string>
    {
        public bool IsPalindrome(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var isPalindrome = false;
            
            var word2 = input?.Reverse();

            if (input.SequenceEqual(word2))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
