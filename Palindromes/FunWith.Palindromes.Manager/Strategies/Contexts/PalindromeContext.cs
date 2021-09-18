using Fun.With.Dev.Palindromes.Contracts;

namespace FunWith.Palindromes.Manager.Strategies.Contexts
{
    /// <summary>
    /// Client class for checking palindromes in the strategy design pattern.
    /// </summary>
    public class PalindromeContext
    {
        IPalindromeInputCheck<int> _palindrome;
        IPalindromeInputCheck<string> _palindromeInputCheck;

        //These are examples of overloading the constructor
        public PalindromeContext() { }

        //This is an example of using the Context client class which contains various implementations. 
        //In a normal project you would probably use the string implementation instead of the integer implementation.
        public PalindromeContext(IPalindromeInputCheck<int> palindrome, IPalindromeInputCheck<string> palindromeInputCheck)
        {
            if (palindrome != null)
            {
                _palindrome = palindrome;
            }

            if (palindromeInputCheck != null)
            {
                _palindromeInputCheck = palindromeInputCheck;
            }
        }

        public PalindromeContext(IPalindromeInputCheck<string> palindromeInputCheck)
        {
            if (palindromeInputCheck != null)
            {
                _palindromeInputCheck = palindromeInputCheck;
            }
        }

        public bool IsPalindrome(int input) => (bool)_palindrome?.IsPalindrome(input);

        public bool? IsPalindrome(string input)
        {
            return _palindromeInputCheck?.IsPalindrome(input);
        }
    }
}
