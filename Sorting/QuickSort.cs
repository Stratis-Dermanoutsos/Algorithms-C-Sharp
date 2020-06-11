using System.Collections.Generic;

namespace Sorting_Functions
{
    class QuickSort<T> // O(n*log(n))
    {
        string output = "{ ";

        public QuickSort(T[] list)
        {
            Sort(list, 0, list.Length-1);

            // Prepare the output
            foreach (T item in list) {
                output += item.ToString();

                if (Comparer<T>.Default.Compare(item, list[list.Length - 1]) != 0)
                    output += ", ";
            }

            output += " }";
        }

        // Algorithm {
        public void Sort(T[] list, int left, int right)
        {
            int pivot; // Index of our pivot point

            if (left < right) {
                pivot = Partition(list, left, right);

                if (pivot > 1) // Sort the first half
                    Sort(list, left, pivot - 1);

                if (pivot + 1 < right) // Sort the second half
                    Sort(list, pivot + 1, right);
            }
        }

        private int Partition(T[] list, int left, int right)
        {
            T pivot;
            pivot = list[left];

            while (true) {
                // list[left] < pivot
                while (Comparer<T>.Default.Compare(list[left], pivot) < 0)
                    left++;

                // list[right] > pivot
                while (Comparer<T>.Default.Compare(list[right], pivot) > 0)
                    right--;

                if (left < right) {
                    T temp = list[right];
                    list[right] = list[left];
                    list[left] = temp;
                } else
                    return right;
            }
        }
        // }

        public override string ToString() { return this.output; } // Output
    }
}
