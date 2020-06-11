using System.Collections.Generic;

namespace Sorting_Functions
{
    class SelectionSort<T> // O(n^2)
    {
        string output = "{ ";

        public SelectionSort(T[] list)
        {
            // Algorithm {
            int smallestItemIndex = 0;

            for (int i = 0; i < list.Length; i++) {
                int min = i; // Set the current index as minimum
                T temp = list[i];

                for (int j = i+1; j < list.Length; j++)
                    if (Comparer<T>.Default.Compare(list[j], list[min]) < 0) // Ascending order
                        min = j; // Update minimum if current element is lower than previous

                // Exchange items
                list[i] = list[min];
                list[min] = temp;
            }
            // }

            // Prepare the output
            foreach (T item in list) {
                output += item.ToString();

                if (Comparer<T>.Default.Compare(item, list[list.Length - 1]) != 0)
                    output += ", ";
            }

            output += " }";
        }

        public override string ToString() { return this.output; } // Output
    }
}
