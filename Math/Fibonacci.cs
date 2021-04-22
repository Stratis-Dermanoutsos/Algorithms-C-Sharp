using System.Numerics;

namespace Algorithms_C_Sharp.Math
{
    class Fibonacci
    {
        public static BigInteger FibonacciNumber(int n) // We start counting from 0
        {
            if (n < 0) return -1; // n must be non-negative

            if (n < 2) return n; // for n < 2, Fn = n

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2); // Fn = Fn-1 + Fn-2
        }
    }
}
