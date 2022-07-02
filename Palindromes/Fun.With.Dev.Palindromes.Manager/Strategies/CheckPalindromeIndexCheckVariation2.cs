using Fun.With.Dev.Palindromes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Palindromes.Manager.Strategies
{
    /// <summary>
    /// This implementation will check the first index of the input and last index of the input and move to the middle.
    /// </summary>
    public class CheckPalindromeIndexCheckVariation2 : IPalindromeInputCheck<string>
    {
        public bool IsPalindrome(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var inputTrimmed = input.Trim();

            var isPalindrome = false;

            //var word2 = input?.Reverse();

            //if (input?.SequenceEqual(word2) == true)
            //{
            //    isPalindrome = true;
            //}

            //Use a simple for loop
            var lastChar = inputTrimmed.Last();
            var lastIndex = inputTrimmed.LastIndexOf(lastChar);
            for(int index = 0; index < input.Length; index++)
            {
                //if the input is odd that means we can skip the middle letter.
                if (index < lastIndex)
                {
                    if (input[index] == input[lastIndex])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                    }

                    lastIndex--; 
                }
            }

            return isPalindrome;
        }
    }
}
