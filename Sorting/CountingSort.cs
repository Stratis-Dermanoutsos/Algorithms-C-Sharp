public void CountingSort(int[] array) // O(n+k)
{
  int[] count = new int[array.Max() + 1];

  // Count our elements' occurences
  for (int i = 0; i < array.Length; i++)
    count[array[i]]++;

  int counter = 0;
  /* Build the output array. */
  for (int i = 0; i < count.Length; i++)
    while (count[i] > 0) {
      array[counter++] = i;
      count[i]--;
    }

  // Prepare the output
  string output = "{ ";

  foreach (int item in array) {
    output += item.ToString();
    
    if (item != array[array.Length - 1])
      output += ", ";
  }

  output += " }";

  System.Console.WriteLine(output);
}
