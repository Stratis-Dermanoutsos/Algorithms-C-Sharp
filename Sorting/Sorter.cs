using System.Collections.Generic;
using System.Linq;

namespace Sorting_Functions
{
    class Sorter<T>
    {
        // Bubble Sort {
        public T[] BubbleSort(T[] list) // O(n^2)
        {
            for (int i = 0; i < list.Length; i++)
                for (int j = list.Length - 1; j > i; j--)
                    if (Comparer<T>.Default.Compare(list[j], list[j - 1]) < 0) { // Ascending order
                        T temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }

            return list;
        }
        // }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // Insertion Sort {
        public T[] InsertionSort(T[] list) // O(n^2)
        {
            for (int i = 0; i < list.Length-1; i+=2)
                for (int j = i+1; j < list.Length; j++)
                    if (Comparer<T>.Default.Compare(list[j], list[i]) < 0) { // Ascending order
                        T temp = list[j]; // Keep the value
                        // Shift the previous items
                        for (int k = j; k > i; k--)
                            list[k] = list[k - 1];
                        list[i] = temp; // Place our value in the wanted position
                        break; // Go to the next item
                    }

            return list;
        }
        // }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // Merge Sort {
        public List<T> MergeSort(T[] list) // O(n*logn)
        {
            List<T> myList = list.OfType<T>().ToList();

            if (myList.Count <= 1)
                return myList;

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            //Dividing the unsorted list
            int middle = myList.Count / 2;
            for (int i = 0; i < middle; i++) // First half
                left.Add(list[i]);
            for (int i = middle; i < myList.Count; i++) // Second half
                right.Add(list[i]);

            // Using recursion, merge the 2 lists while sorting the result
            return Merge(
                MergeSort(left.ToArray()),
                MergeSort(right.ToArray())
                );
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            List<T> result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
                if (left.Count > 0 && right.Count > 0) // If both lists have remaining items
                    //Comparing First two elements to see which is smaller 
                    if (Comparer<T>.Default.Compare(left.First(), right.First()) <= 0) {
                        result.Add(left.First());
                        left.Remove(left.First()); //Remove the first element
                    } else {
                        result.Add(right.First());
                        right.Remove(right.First()); //Remove the first element
                    }
                else if (left.Count > 0) { // If only the left list has remaining items
                    result.Add(left.First());
                    left.Remove(left.First());
                } else if (right.Count > 0) { // If only the right list has remaining items
                    result.Add(right.First());
                    right.Remove(right.First());
                }

            return result;
        }
        // }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // Selection Sort {
        public T[] SelectionSort(T[] list) // O(n^2)
        {
            for (int i = 0; i < list.Length; i++) {
                int min = i; // Set the current index as minimum
                T temp = list[i];

                for (int j = i+1; j < list.Length; j++)
                    if (Comparer<T>.Default.Compare(list[j], list[min]) < 0) // Ascending order
                        min = j; // Update minimum if current element is lower than previous

                // Exchange items
                list[i] = list[min];
                list[min] = temp;
            }

            return list;
        }
        // }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // Quick Sort {
        public T[] QuickSort(T[] list, int left, int right) // O(n*logn)
        {
            int pivot; // Index of our pivot point

            if (left < right) {
                pivot = Partition(list, left, right);

                if (pivot > 1) // Sort the first half
                    QuickSort(list, left, pivot - 1);

                if (pivot + 1 < right) // Sort the second half
                    QuickSort(list, pivot + 1, right);
            }

            return list;
        }

        private int Partition(T[] list, int left, int right)
        {
            T pivot;
            pivot = list[left];

            while (true) {
                // list[left] < pivot
                while (Comparer<T>.Default.Compare(list[left], pivot) < 0)
                    left++;

                // list[right] > pivot
                while (Comparer<T>.Default.Compare(list[right], pivot) > 0)
                    right--;

                if (left < right) {
                    T temp = list[right];
                    list[right] = list[left];
                    list[left] = temp;
                } else
                    return right;
            }
        }
        // }
    }
}
