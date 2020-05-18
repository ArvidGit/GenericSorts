using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort<T> : ISortingAlgorithm<T> where T : IComparable
    {
        public List<T> Sort(List<T> list)
        {
            SortList(ref list, 0, list.Count - 1);
            return list;
        }

        void SortList(ref List<T> list, int start, int end)
        {
            int middle = (start + end) / 2;
            int i = start;
            int j = end;
            T pivot = list[middle]; 
            do
            {
                while(list[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while(list[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    T temp = list[j];
                    list[j] = list[i];
                    list[i] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (start < j)
            {
                SortList(ref list, start, j);
            }
            if (i < end)
            {
                SortList(ref list, i, end);
            }
        }
    }
}
