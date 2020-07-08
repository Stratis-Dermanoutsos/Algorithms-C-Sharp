System.Numerics.BigInteger Factorial(int n)
{
  if (n < 0) return -1; // n must be non-negative

  if (n < 2) return 1; // both 0! and 1! equal 1

  return n * Factorial(n - 1); // n! = n*(n-1)*(n-2)*...*1
}
