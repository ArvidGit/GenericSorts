using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class ShellSort<T> : ISortingAlgorithm<T> where T : IComparable
    {
        public List<T> Sort(List<T> list)
        {
            int size = list.Count;
            for(int gap = size/2; gap >0; gap /= 2)
            {
                for(int i = gap; i < size; i++)
                {
                    T temp = list[i];
                    int j;
                    for (j = i; j >= gap && list[j - gap].CompareTo(temp) > 0; j -= gap)
                    {
                        list[j] = list[j - gap];
                    }

                    list[j] = temp;
                }
            }
            return list;
        }
    }
}
