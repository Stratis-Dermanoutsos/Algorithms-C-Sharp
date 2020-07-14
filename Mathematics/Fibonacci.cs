public System.Numerics.BigInteger Fibonacci(int n) // We start counting from 0
{
  if (n < 0) return -1; // n must be non-negative

  if (n < 2) return n; // for n < 2, Fn = n

  return Fibonacci(n - 1) + Fibonacci(n - 2); // Fn = Fn-1 + Fn-2
}
