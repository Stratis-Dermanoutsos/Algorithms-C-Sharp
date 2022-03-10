using System.Numerics;

namespace Algorithms_C_Sharp.Math
{
    class Catalan
    {
        public static BigInteger CatalanNumber(int n) // We start counting from 0
        {
            if (n < 0) return -1; // n must be non-negative

            if (n < 2) return 1; // Catalan of both 0 and 1 equal 1

            BigInteger result = 0;
            for (int i = 0; i < n; i++)
                result += CatalanNumber(i) * CatalanNumber(n - i - 1);

            return result; // Cn = (2n)! / ((n + 1)! * n!)
        }
    }
}
