using System.Collections.Generic;

namespace Sorting_Functions
{
    class BubbleSort<T> // O(n^2)
    {
        string output = "{ ";

        public BubbleSort(T[] list)
        {
            // Algorithm {
            for (int i = 0; i < list.Length; i++)
                for (int j = list.Length - 1; j > i; j--)
                    if (Comparer<T>.Default.Compare(list[j], list[j - 1]) < 0) { // Ascending order
                        T temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
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
