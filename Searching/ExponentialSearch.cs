int ExponentialSearch(T[] list, T item) // O(logn)
{
  int n = list.Length; // We store the length

  // If x is present at first location itself 
  if (Comparer<T>.Default.Compare(list[0], item) == 0)
    return 0;

  // Find range for binary search by repeated doubling 
  int i = 1;
  while (i < n && Comparer<T>.Default.Compare(list[i], item) <= 0)
    i = i * 2;

  // Call our Binary Recursive Search method (can be found in this directory) for the found range
  return BinaryRecursiveSearch(list, i / 2, Math.Min(i, n), item);
}
