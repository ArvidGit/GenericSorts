using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort<T> : ISortingAlgorithm<T> where T : IComparable
    {
        public List<T> Sort(List<T> list)
        {
            int i = 1;
            while(i < list.Count) {
                int j = i;
                while(j > 0 && list[j-1].CompareTo(list[j]) > 0)
                {
                    T temp = list[j];
                    list[j] = list[j-1];
                    list[j-1] = temp;
                    j--;
                }
                i++;
    
            }
            return list;
   
        }
    }
}
