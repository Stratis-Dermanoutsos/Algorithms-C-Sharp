long RecursiveSquare(int n)
{
  if (n >= 0) // For non-negative n
    return (n == 1 || n == 0) ? n : RecursiveSquare(n - 1) + n + n - 1;

  // For negative n
  return (n == -1) ? 1 : RecursiveSquare(-n + 1) + n + n - 1;
}
