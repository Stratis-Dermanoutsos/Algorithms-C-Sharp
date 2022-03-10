using System.Collections.Generic;

namespace Algorithms_C_Sharp.Search
{
    class Exponential
    {
        public static int ExponentialSearch<T>(T[] array, T item) // O(logn)
        {
            int n = array.Length; // We store the length

            /* If x is present at first location itself */
            if (Comparer<T>.Default.Compare(array[0], item) == 0)
                return 0;

            /* Find range for binary search by repeated doubling */
            int i = 1;
            /* array[i] <= item */
            while (i < n && Comparer<T>.Default.Compare(array[i], item) <= 0)
                i = i * 2;

            /* Call our Binary Recursive Search method (can be found in this directory) for the found range */
            return BinaryRecursive.BinaryRecursiveSearch(array, i / 2, System.Math.Min(i, n), item);
        }
    }
}
