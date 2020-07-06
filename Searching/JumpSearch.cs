int JumpSearch(T[] list, T item) // Between O(logn) and O(n)
{
  // number of elements to skip with each step
  int n = list.Length;
  int step = (int)Math.Floor(Math.Sqrt(n));
  int prev = 0;

  // Jump as many times as needed to just barely get past the specified item
  // If we get past its value, item does not exist so return -1
  while (Comparer<T>.Default.Compare(list[Math.Min(step, n) - 1], item) < 0) {
    prev = step;
    step += step;
    if (prev >= n)
    return -1;
  }

  // Perform linear search after we reach the wanted block to find the specified item
  while (Comparer<T>.Default.Compare(list[prev], item) < 0) {
    prev++;

    // If we reached next block or end of array, item does not exist so return -1
    if (prev == Math.Min(step, n))
    return -1;
  }

  // If found, return the index. Else, return -1
  return (Comparer<T>.Default.Compare(list[prev], item) == 0) ? prev : -1;
}
