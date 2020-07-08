public System.Numerics.BigInteger Fibonacci(int n) // We start counting from 0
{
  if (n < 0) return -1; // n must be non-negative

  if (n < 2) return n; // f(0) = 0 and f(1) = 1

  return Fibonacci(n - 1) + Fibonacci(n - 2); // f(n) = f(n-1) + f(n-2)
}
