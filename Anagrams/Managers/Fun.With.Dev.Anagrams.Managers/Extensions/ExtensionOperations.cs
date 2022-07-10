using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Anagrams.Managers.Extensions
{
    /// <summary>
    /// Extension methods for demonstration and discussions.
    /// </summary>
    public static class ExtensionOperations
    {
        /// <summary>
        /// C# lets you define extensions but you have to use a static class and method with the "this" keyword.
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public static bool IsAnagramV1(string input1, string input2)
        {
            if (input1 == null)
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
                if (input1?.Length > input2?.Length)
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
