using System.Collections.Generic;

namespace Algorithms_C_Sharp.Search
{
    class Linear
    {
        public static int LinearSearch<T>(T[] array, T item) // O(n)
        {
            for (int i = 0; i < array.Length; i++)
                /* array[i] == item */
                if (Comparer<T>.Default.Compare(array[i], item) == 0)
                    return i;

            return -1; // Not found
        }

    }
}
