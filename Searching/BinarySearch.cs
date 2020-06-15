int BinarySearch(T[] list, T item) // O(logn)
{
  int left = 0;
  int right = list.Length - 1;

  while (left <= right) {
    int middle = (left + right) / 2;
    
    // Searching
    if (Comparer<T>.Default.Compare(item, list[middle]) > 0)
      left = middle + 1;
    else if (Comparer<T>.Default.Compare(item, list[middle]) < 0)
      right = middle - 1;
    else // If found
      return middle;
  }

  return -1; // If not found
}
