using System.Collections.Generic;

namespace Sorting_Functions
{
    class InsertionSort<T> // O(n^2)
    {
        string output = "{ ";

        public InsertionSort(T[] list)
        {
            // Algorithm {
            for (int i = 0; i < list.Length-1; i+=2)
                for (int j = i+1; j < list.Length; j++)
                    if (Comparer<T>.Default.Compare(list[j], list[i]) < 0) { // Ascending order
                        T temp = list[j]; // Keep the value
                        // Shift the previous items
                        for (int k = j; k > i; k--)
                            list[k] = list[k - 1];
                        list[i] = temp; // Place our value in the wanted position
                        break; // Go to the next item
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
