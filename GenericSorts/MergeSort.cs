using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort<T> : ISortingAlgorithm<T> where T : IComparable
    {
        public List<T> Sort(List<T> list)
        {
            Divide(ref list, 0, list.Count - 1);
            return list;
        }

        void Divide(ref List<T> list, int start, int end)
        {
            if (start < end)
            {
                int center = (start + end) / 2;
                Divide(ref list, start, center);
                Divide(ref list, center+1, end);
                Merge(ref list, start, center, end);
            }

        }

        void Merge(ref List<T> list, int start,int middle, int end)
        {
            int i = start;
            int count = 0;
            int j = middle+1;
            T[] temp = new T[end-start +1];
            while(i <= middle && j <= end)
            {
                if(list[i].CompareTo(list[j]) < 0)
                {
                    temp[count] = list[i];
                    i++;
                }
                else
                {
                    temp[count] = list[j];
                    j++;
                }
                count++;
            }
            while (i <= middle)
            {
                temp[count] = list[i];
                count++;
                i++;
            }
            while (j <= end)
            {
                temp[count] = list[j];
                count++;
                j++;
            }

            for(int k = 0; k <= end-start; k++)
            {
                list[start+k] = temp[k];
            }
        }
    }
}
