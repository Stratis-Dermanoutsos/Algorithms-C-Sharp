using System.Collections.Generic;

namespace Algorithms_C_Sharp.Search
{
    class BinaryRecursive
    {
        public static int BinaryRecursiveSearch<T>(T[] array, int left, int right, T item) // O(logn)
        {
            // Not found
            if (left > right)
                return -1;

            int mid = left + (right - left) / 2;

            /* array[mid] == item */
            if (Comparer<T>.Default.Compare(array[mid], item) == 0)
                return mid;
            /* array[mid] > item */
            else if (Comparer<T>.Default.Compare(array[mid], item) > 0)
                return BinaryRecursiveSearch(array, left, mid - 1, item);
            /* array[mid] < item */
            else
                return BinaryRecursiveSearch(array, mid + 1, right, item);
        }
    }
}
