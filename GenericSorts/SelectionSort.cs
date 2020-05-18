using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort<T> : ISortingAlgorithm<T> where T: IComparable
    {
        public List<T> Sort(List<T> list)
        {
            if(list.Count <= 1)
            {
                return list;
            }
           
            for(int i = 0; i < list.Count-1; i++)
            {
                int min = i;
                for(int j = i+1; j < list.Count; j++)
                {
                    if(list[min].CompareTo(list[j]) > 0)
                    {
                        min = j;
                    }
                }
                if(min != i)
                {
                    T temp = list[i];
                    list[i] = list[min];
                    list[min] = temp;
                }
            }
            return list;
        }
    }
}
