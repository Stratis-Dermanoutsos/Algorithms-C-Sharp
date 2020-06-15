int LinearSearch(T[] list, T item) // O(n)
{
  for (int i = 0; i < list.Length; i++)
    if (Comparer<T>.Default.Compare(list[i], item) == 0)
      return i; // If found, return the index

  return -1; // Else, return -1
}
