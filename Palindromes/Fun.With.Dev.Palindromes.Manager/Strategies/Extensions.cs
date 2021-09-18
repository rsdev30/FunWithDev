using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fun.With.Dev.Palindromes.Manager.Strategies
{
    public static class PalindromeExtensions
    {
        public static bool IsPalindrome(this string input) 
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
