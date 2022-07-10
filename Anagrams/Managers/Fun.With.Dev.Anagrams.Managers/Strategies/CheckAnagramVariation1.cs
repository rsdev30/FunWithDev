using Fun.With.Dev.Anagrams.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Anagrams.Managers.Strategies
{
    /// <summary>
    /// This handles anagrams whens the character count are the same between the two inputs.
    /// TODO: Handle the case of words that are less and a subset.
    /// </summary>
    public class CheckAnagramVariation1 : IAnagramsCheck<string, string>
    {
        public bool IsAnagram(string input1, string input2)
        {
            if(input1 == null)
                return false;

            if (input2 == null)
                return false;

            var ordered1 = input1?.OrderBy(c => c);
            var ordered2 = input2?.OrderBy(c => c);

            if (ordered2 == null)
                return false;

            var isEqual = ordered1?.SequenceEqual(ordered2.AsEnumerable());

            return System.Convert.ToBoolean(isEqual);
        }
    }
}
