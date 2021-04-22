using System.Collections.Generic;

namespace Algorithms_C_Sharp.Sort
{
    class Bubble
    {
        public static void BubbleSort<T>(T[] array) // O(n^2)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = array.Length - 1; j > i; j--)
                    /* array[j] < array[j - 1] */
                    if (Comparer<T>.Default.Compare(array[j], array[j - 1]) < 0) {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
        }
    }
}
