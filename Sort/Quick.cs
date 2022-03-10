using System.Collections.Generic;

namespace Algorithms_C_Sharp.Sort
{
    class Quick
    {
        static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int Partition<T>(T[] arr, int left, int right)
        {
            T pivot = arr[right];

            // Index of smaller element that indicates the right position of pivot
            int i = left - 1;

            for (int j = left; j < right - 1; j++)
                // If current element is smaller than the pivot
                /* arr[j] < pivot */
                if (Comparer<T>.Default.Compare(arr[j], pivot) < 0) {
                    // Increment index of smaller element
                    i++;

                    // Swap elements at indices i and j
                    Swap(arr, i, j);
                }

            // Swap pivot with the last smaller element
            Swap(arr, i + 1, right);

            return i + 1;
        }

        public static void QuickSort<T>(T[] array, int low, int high) // O(nlogn)
        {
            if (low < high) {
                // pi is partitioning index, arr[p] is now at right place 
                int pi = Partition(array, low, high);

                // Separately sort elements before partition and after partition
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }
    }
}
