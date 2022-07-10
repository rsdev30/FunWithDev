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

            if (ordered1 == null)
                return false;

            if (ordered2 == null)
                return false;

            bool? isEqual = false;
            if (input1?.Length == input2?.Length)
            {
                isEqual = ordered1?.SequenceEqual(ordered2.AsEnumerable());
                return System.Convert.ToBoolean(isEqual);
            }
            else
            {
                //in this case the input2 is a subset of the letters in input1.
                if(input1?.Length > input2?.Length)
                {
                    ordered2?.ToList().ForEach(c =>
                    {
                        isEqual = ordered1.Any(x => x.Equals(c));
                    });
                }
                else
                {
                    //vice versa, input1 is a subset of input2
                    ordered1?.ToList().ForEach(c =>
                    {
                        isEqual = ordered2.Any(x => x.Equals(c));
                    });
                }
            }

            return System.Convert.ToBoolean(isEqual);
        }
    }
}
