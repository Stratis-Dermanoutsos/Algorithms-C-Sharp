using System.Numerics;

namespace Algorithms_C_Sharp.Math
{
    class Factorial
    {
        public static BigInteger FactorialNumber(int n)
        {
            if (n < 0) return -1; // n must be non-negative

            if (n < 2) return 1; // both 0! and 1! equal 1

            return n * FactorialNumber(n - 1); // n! = n*(n-1)*(n-2)*...*1
        }
    }
}
