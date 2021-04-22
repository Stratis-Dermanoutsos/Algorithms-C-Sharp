using System;

namespace Algorithms_C_Sharp
{
    class Playground
    {
        static void Main(string[] args)
        {
            string[] arr = { "meh man", "me man", "idk", "abc", "idk" };
            int[] arr1 = { 1, 4, 45, 2, 4, 3, 74, 8, 32, 14, 43, 2, 3, 3, 1 };

            Sort.Selection.SelectionSort<string>(arr);
            Sort.Counting.CountingSort(arr1);

            foreach (int item in arr1)
                Console.WriteLine($"{item}");

            int i = Search.Jump.JumpSearch<int>(arr1, 3);
            Console.WriteLine($"{i}");

            //Console.WriteLine(Math.SquareRecursive.SquareRecursiveNumber(100));
        }
    }
}
