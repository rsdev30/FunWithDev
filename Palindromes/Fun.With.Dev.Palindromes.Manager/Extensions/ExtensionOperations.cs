using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Palindromes.Manager.Extensions
{
    /// <summary>
    /// Example of using extensions in C# as an alternative. 
    /// </summary>
    public static class ExtensionOperations
    {
        public static bool IsPalindrome(this string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var isPalindrome = false;

            var word2 = input?.Reverse();

            if (input?.SequenceEqual(word2) == true)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
}
