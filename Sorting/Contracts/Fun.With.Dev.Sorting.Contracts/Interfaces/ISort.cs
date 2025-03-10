﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.With.Dev.Sorting.Contracts.Interfaces
{
    public interface ISort<TResult, TInput>
    {
        public Task<TResult> Sort(TInput input);
    }
}
