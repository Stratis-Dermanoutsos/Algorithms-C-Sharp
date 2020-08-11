long RecursiveSquare(int n)
{
  return (n == 1 || n == 0) ? n : RecursiveSquare(n-1) + n + n-1;
}
