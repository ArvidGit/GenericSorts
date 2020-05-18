using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDataStructures;

namespace Sorting
{
    // Don't think this is how its usually implemeted but should work fine
    public class HeapSort<T> : ISortingAlgorithm<T> where T : IComparable 
    {
        public List<T> Sort(List<T> list)
        {
            Heap<T> h = new Heap<T>(list.Count+1, false);//Creates a heap from a heap class I implemented
            foreach(T x in list) //Adds every element to the heap
            {
                h.Add(x);
            }
            List<T> temp = new List<T>();
            while(!h.IsEmpty()) //Removes every element from the heap
            {
                T t = h.RemoveFirst();
                temp.Add(t);
            }
            return temp;
        }

    }
}
