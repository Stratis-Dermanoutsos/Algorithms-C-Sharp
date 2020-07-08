// Utility function to find minimum of two elements 
int min(int x, int y)
{
  return (x <= y) ? x : y;
}

int FibonacciSearch(T[] list, T item) // O(logn)
{
  int n = list.Length; // We store the length

  // Initialize fibonacci numbers
  int fibMMm2 = 0; // (m-2)'th Fibonacci No. 
  int fibMMm1 = 1; // (m-1)'th Fibonacci No. 
  int fibM = fibMMm2 + fibMMm1; // m'th Fibonacci 

  // fibM is going to store the smallest Fibonacci Number greater than or equal to n
  while (fibM < n) {
    fibMMm2 = fibMMm1;
    fibMMm1 = fibM;
    fibM = fibMMm2 + fibMMm1;
  }

  // Marks the eliminated range from front 
  int offset = -1;

  // While there are elements to be inspected. Note that we compare list[fibMm2] with item. When fibM becomes 1, fibMm2 becomes 0
  while (fibM > 1)
  {
    // Check if fibMm2 is a valid location 
    int i = min(offset + fibMMm2, n - 1);

    // If x is greater than the value at index fibMm2, cut the subarray array from offset to i
    if (Comparer<T>.Default.Compare(list[i], item) < 0) {
      fibM = fibMMm1;
      fibMMm1 = fibMMm2;
      fibMMm2 = fibM - fibMMm1;
      offset = i;
    } // If x is greater than the value at index fibMm2, cut the subarray after i+1
    else if (Comparer<T>.Default.Compare(list[i], item) > 0) {
      fibM = fibMMm2;
      fibMMm1 = fibMMm1 - fibMMm2;
      fibMMm2 = fibM - fibMMm1;
    } else // Item found. return index
      return i;
  }

  // If found, return the index. Else, return -1
  return (fibMMm1 == 1 && Comparer<T>.Default.Compare(list[offset + 1], item) == 0) ? offset + 1 : -1;
}
