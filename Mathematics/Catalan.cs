System.Numerics.BigInteger Catalan(int n) // We start counting from 0
{
  if (n < 0) return -1; // n must be non-negative

  if (n < 2) return 1; // Both Catalan of 0 and 1 equal 1

  // We calculate the Catalan of n
  System.Numerics.BigInteger result = 0;
  for (int i = 0; i < n; i++)
    result += Catalan(i) * Catalan(n - i - 1);

  return result; // Cn = (2n)! / ((n + 1)! * n!)
}
