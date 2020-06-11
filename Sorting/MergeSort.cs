using System.Collections.Generic;
using System.Linq;

namespace Sorting_Functions
{
    class MergeSort<T> // O(n*log(n))
    {
        string output = "{ ";

        public MergeSort(T[] list)
        {
            list = Sort(list.OfType<T>().ToList()).ToArray();
            // We use list for easier Additions and Removals of elements

            // Prepare the output
            foreach (T item in list) {
                output += item.ToString();

                if (Comparer<T>.Default.Compare(item, list[list.Length - 1]) != 0)
                    output += ", ";
            }

            output += " }";
        }

        // Algorithm {
        private List<T> Sort(List<T> list)
        {
            if (list.Count <= 1)
                return list;

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            //Dividing the unsorted list
            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++) // First half
                left.Add(list[i]);
            for (int i = middle; i < list.Count; i++) // Second half
                right.Add(list[i]);

            // Using recursion, merge the 2 lists while sorting the result
            return Merge(
                Sort(left), 
                Sort(right)
                );
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            List<T> result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
                if (left.Count > 0 && right.Count > 0) // If both lists have remaining items
                    //Comparing First two elements to see which is smaller 
                    if (Comparer<T>.Default.Compare(left.First(), right.First()) <= 0) {
                        result.Add(left.First());
                        left.Remove(left.First()); //Remove the first element
                    } else {
                        result.Add(right.First());
                        right.Remove(right.First()); //Remove the first element
                    }
                else if (left.Count > 0) { // If only the left list has remaining items
                    result.Add(left.First());
                    left.Remove(left.First());
                } else if (right.Count > 0) { // If only the right list has remaining items
                    result.Add(right.First());
                    right.Remove(right.First());
                }

            return result;
        }
        // }

        public override string ToString() { return this.output; } // Output
    }
}
