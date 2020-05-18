using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISortingAlgorithm<T> where T : IComparable
    {
        List<T> Sort(List<T> list);
    }
}
