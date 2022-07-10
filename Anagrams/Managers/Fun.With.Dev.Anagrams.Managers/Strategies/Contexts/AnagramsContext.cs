using Fun.With.Dev.Anagrams.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Anagrams.Managers.Strategies.Contexts
{
    public class AnagramsContext
    {
        IAnagramsCheck<string, string> _anagramsCheck;

        public AnagramsContext(IAnagramsCheck<string, string> anagramsCheck)
        {
            _anagramsCheck = anagramsCheck;
        }

        public bool IsAnagram(string input1, string input2)
        {
            return System.Convert.ToBoolean(_anagramsCheck?.IsAnagram(input1, input2));
        }
    }
}
