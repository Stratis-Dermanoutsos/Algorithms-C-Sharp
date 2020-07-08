System.Numerics.BigInteger Fibonacci(int n) // Return the n-th Fibonacci number
{
  if (n < 2) return n; // f(0) = 0 and f(1) = 1

  return Fibonacci(n - 1) + Fibonacci(n - 2); // f(n) = f(n-1) + f(n-2)
}
