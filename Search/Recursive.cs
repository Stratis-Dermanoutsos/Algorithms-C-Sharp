using System.Collections.Generic;

namespace Algorithms_C_Sharp.Search
{
    class Recursive
    {
        public static int RecursiveSearch<T>(T[] array, int left, int right, T item) // O(n/2) --> O(n)
        {
            // Not found
            if (right < left)
                return -1;

            /* array[left] == item */
            if (Comparer<T>.Default.Compare(array[left], item) == 0)
                return left;

            /* array[right] == item */
            if (Comparer<T>.Default.Compare(array[right], item) == 0)
                return right;

            // Else, continue searching
            return RecursiveSearch(array, left + 1, right - 1, item);
        }
    }
}
