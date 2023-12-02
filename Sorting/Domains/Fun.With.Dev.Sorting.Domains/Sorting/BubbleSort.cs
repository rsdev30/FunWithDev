using Fun.With.Dev.Sorting.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Sorting.Domains.Sorting
{
    public class BubbleSort : IBubbleSort<IList<int>, IList<int>>
    {         
        public async Task<IList<int>> Sort(IList<int> input)
        {
            return await Task.Run(() =>
            {
                var wasSwapped = false;                
                var n = input.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    for (var j = 0; j < n - i - 1; j++)
                    {
                        wasSwapped = false;

                        if (input[j] > input[j + 1])
                        {
                            var temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = temp;
                            wasSwapped = true;
                        }
                    }

                    if (!wasSwapped)
                        break;

                }

                return input;
            });
        }
    }
}
