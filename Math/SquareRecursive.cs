using System.Numerics;

namespace Algorithms_C_Sharp.Math
{
    class SquareRecursive
    {
        public static BigInteger SquareRecursiveNumber(int n)
        {
            if (n >= 0) // For non-negative n
                return (n == 1 || n == 0) ? n : SquareRecursiveNumber(n - 1) + n + n - 1;

            // For negative n
            return (n == -1) ? 1 : SquareRecursiveNumber(-n + 1) + n + n - 1;
        }
    }
}
