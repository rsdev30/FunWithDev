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
        public static bool IsAnagramV1(this string input1, string input2)
        {
            if (input1 == null)
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
