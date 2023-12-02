using Fun.With.Dev.Sorting.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Sorting.Domains.Sorting
{
    public class MergeSort : ISort<IList<int>, IList<int>>
    {
        public int[] Sort(int[] input)
        {
            throw new NotImplementedException();
        }

        public Task<IList<int>> Sort(IList<int> input)
        {
            throw new NotImplementedException();
        }
    }
}
