using System.Collections.Generic;

namespace Algorithms_C_Sharp.Search
{
    class Binary
    {
        public static int BinarySearch<T>(T[] array, T item) // O(logn)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right) {
                int mid = (left + right) / 2;

                /* item > array[mid] */
                if (Comparer<T>.Default.Compare(item, array[mid]) > 0)
                    left = mid + 1;
                /* item < array[mid] */
                else if (Comparer<T>.Default.Compare(item, array[mid]) < 0)
                    right = mid - 1;
                /* item == array[mid] */
                else
                    return mid;
            }

            return -1; // Not found
        }
    }
}
