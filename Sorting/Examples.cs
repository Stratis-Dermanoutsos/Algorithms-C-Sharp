using System;

namespace Sorting_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] floats = new float[] { 6.9f, 2.5f, 2.1f, 23.0f, 12, 2, 3, 6 };
            int[] integers = new int[] { 9, 6, 5, 3, 10, 1, 8, 7, 2, 4 };
            char[] characters = new char[] { 'a', 'e', 'r', 'd', 'v', 'z', 'b', 'c' };

            Console.WriteLine("Bubble Sort (float): " + new BubbleSort<float>(floats).ToString());
            Console.WriteLine("Bubble Sort (int): "+ new BubbleSort<int>(integers).ToString());
            Console.WriteLine("Bubble Sort (char): " + new BubbleSort<char>(characters).ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Selection Sort (float): " + new SelectionSort<float>(floats).ToString());
            Console.WriteLine("Selection Sort (int): " + new SelectionSort<int>(integers).ToString());
            Console.WriteLine("Selection Sort (char): " + new SelectionSort<char>(characters).ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Insertion Sort (float): " + new InsertionSort<float>(floats).ToString());
            Console.WriteLine("Insertion Sort (int): " + new InsertionSort<int>(integers).ToString());
            Console.WriteLine("Insertion Sort (char): " + new InsertionSort<char>(characters).ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Merge Sort (float): " + new MergeSort<float>(floats).ToString());
            Console.WriteLine("Merge Sort (int): " + new MergeSort<int>(integers).ToString());
            Console.WriteLine("Merge Sort (char): " + new MergeSort<char>(characters).ToString());
        }
    }
}
