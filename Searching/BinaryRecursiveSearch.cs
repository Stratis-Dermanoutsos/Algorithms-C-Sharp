int BinaryRecursiveSearch(T[] list, int left, int right, T item) // O(logn)
{
  // If left > right, the item cannot be found, so we return -1
  if (left > right)
    return -1;

  int mid = left + (right - left) / 2; // We find the element in the middle

  // If the element is present at the middle itself, return the index
  if (Comparer<T>.Default.Compare(list[mid], item) == 0)
    return mid;
  // If element is smaller than mid, then it can only be present in left subarray 
  else if (Comparer<T>.Default.Compare(list[mid], item) > 0)
    return BinaryRecursiveSearch(list, left, mid - 1, item);
  else // Else the element can only be present in right subarray
    return BinaryRecursiveSearch(list, mid + 1, right, item);
}
