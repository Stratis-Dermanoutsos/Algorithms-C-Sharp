using System.Linq;

namespace Algorithms_C_Sharp.Sort
{
    class Counting
    {
        public static void CountingSort(int[] array) // O(n+k)
        {
            int[] count = new int[array.Max() + 1];

            /* Count our elements' occurences */
            for (int i = 0; i < array.Length; i++)
                count[array[i]]++;

            int counter = 0;
            /* Build the output array. */
            for (int i = 0; i < count.Length; i++)
                while (count[i] > 0) {
                    array[counter++] = i;
                    count[i]--;
                }
        }
    }
}
