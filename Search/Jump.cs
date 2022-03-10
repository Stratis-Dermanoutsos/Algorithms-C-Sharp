using System.Collections.Generic;

namespace Algorithms_C_Sharp.Search
{
    class Jump
    {
        public static int JumpSearch<T>(T[] array, T item) // Between O(logn) and O(n)
        {
            int n = array.Length; // We store the length

            /* Number of elements to skip with each step */
            int step = (int)System.Math.Floor(System.Math.Sqrt(n));

            int prev = 0;

            /* Jump as many times as needed to just barely get past the specified item
             * If we get past its value, item does not exist so return -1 
             * array[System.Math.Min(step, n) - 1] < item */
            while (Comparer<T>.Default.Compare(array[System.Math.Min(step, n) - 1], item) < 0) {
                prev = step;
                step += step;
                if (prev >= n)
                    return -1;
            }

            /* Perform linear search after we reach the wanted block to find the specified item
             * array[prev] < item */
            while (Comparer<T>.Default.Compare(array[prev], item) < 0) {
                prev++;

                /* If we reached next block or end of array, item does not exist so return -1 */
                if (prev == System.Math.Min(step, n))
                    return -1;
            }

            /* If found, return the index. Else, return -1 */
            return (Comparer<T>.Default.Compare(array[prev], item) == 0) ? prev : -1;
        }
    }
}
