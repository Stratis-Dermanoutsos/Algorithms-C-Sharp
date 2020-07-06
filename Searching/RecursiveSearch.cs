int RecursiveSearch(T[] list, int left, int right, T item) // O(n/2) --> O(n)
{
  if (right < left) // If the specified item is not found, return -1
    return -1;

  // If list[left] is the specified item
  if (Comparer<T>.Default.Compare(list[left], item) == 0) 
    return left;

  // If list[right] is the specified item
  if (Comparer<T>.Default.Compare(list[right], item) == 0) 
    return right;

  // Else, continue searching
  return RecursiveSearch(list, left + 1, right - 1, item);
}
