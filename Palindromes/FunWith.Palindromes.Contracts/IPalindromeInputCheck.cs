using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWith.Palindromes.Contracts
{
    public interface IPalindromeInputCheck<TInput>
    {
        bool IsPalindrome(TInput input);
    }
}
