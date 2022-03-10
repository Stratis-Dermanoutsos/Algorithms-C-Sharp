using System.Collections.Generic;

namespace Algorithms_C_Sharp.Sort
{
    class Selection
    {
        public static void SelectionSort<T>(T[] array) // O(n^2)
        {
            for (int i = 0; i < array.Length; i++) {
                int min = i; // Set the current index as minimum
                T temp = array[i];

                for (int j = i + 1; j < array.Length; j++)
                    /* array[j] < array[min] */
                    if (Comparer<T>.Default.Compare(array[j], array[min]) < 0)
                        min = j; // Update minimum if current element is lower than previous

                // Exchange items
                if (i != min) {
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
        }
    }
}
