using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort<T> : ISortingAlgorithm<T> where T : IComparable
    {
        public List<T> Sort(List<T> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].CompareTo(list[j]) > 0)
                    {
                        T temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
        
    }
}
