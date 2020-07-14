// A utility function to find the vertex with minimum distance value, from the 
// set of vertices not yet included in shortest path tree 
int MinDistance(int[] dist, bool[] isInShortestPath)
{
  // Initialize min value 
  int min = int.MaxValue;
  int minIndex = -1;

  for (int i = 0; i < dist.Length; i++)
    if (isInShortestPath[i] == false && dist[i] <= min) {
      min = dist[i];
      minIndex = i;
    }

  return minIndex;
}

int[] Dijkstra(int[,] graph, int start)
{
  int length = graph.GetLength(1);

  // The output array. distanceOf[i] will hold the shortest distance from start to i 
  int[] distanceOf = new int[length];

  // isInShortestPath[i] will equal true if vertex i is included in shortest path 
  // tree or shortest distance from start to i is finalized 
  bool[] isInShortestPath = new bool[length];

  // Initialize all distances as INFINITE and isInShortestPath[] as false 
  for (int i = 0; i < length; i++) {
    distanceOf[i] = int.MaxValue;
    isInShortestPath[i] = false;
  }

  // Distance of source vertex from itself is always 0 
  distanceOf[start] = 0;

  // Find shortest path for all vertices 
  for (int j = 0; j < length - 1; j++) {
    // Pick the minimum distance vertex from the set of vertices not yet 
    // processed. minIndex is always equal to start in first iteration
    int minIndex = MinDistance(distanceOf, isInShortestPath);

    // Mark the picked vertex as processed 
    isInShortestPath[minIndex] = true;

    // Update distanceOf value of the adjacent vertices of the picked vertex
    for (int i = 0; i < length; i++)
      // Update distanceOf[i] only if is not in isInShortestPath, there is an edge from minIndex 
      // to i, and total weight of path from start to i through minIndex is smaller 
      // than current value of distanceOf[i] 
      if (!isInShortestPath[i] && graph[minIndex, i] != 0 && distanceOf[minIndex] != int.MaxValue 
        && distanceOf[minIndex] + graph[minIndex, i] < distanceOf[i])
        distanceOf[i] = distanceOf[minIndex] + graph[minIndex, i];
  }

  return distanceOf;
}

// A utility function to print the constructed distance array 
void SolutionVisual(int[] dist)
{
  Console.Write("Vertex     Distance from Source\n");
  for (int i = 0; i < dist.Length; i++)
    Console.Write(i + "\t   " + dist[i] + "\n");
}

/* ~~~~~~~~~~~~~~~ USAGE ~~~~~~~~~~~~~~~
int[,] graph = new int[,] {
  { 0, 2, 0, 0, 0, 0, 0, 10, 0 },
  { 2, 0, 5, 0, 0, 0, 0, 11, 0 },
  { 0, 5, 0, 7, 0, 4, 0, 0, 7 },
  { 0, 0, 7, 0, 9, 12, 0, 0, 0 },
  { 0, 0, 0, 9, 0, 8, 0, 0, 0 },
  { 0, 0, 4, 12, 8, 0, 7, 0, 0 },
  { 0, 0, 0, 0, 0, 7, 0, 4, 3 },
  { 10, 11, 0, 0, 0, 0, 4, 0, 7 },
  { 0, 0, 7, 0, 0, 0, 3, 7, 0 }
};

int[] pathsLengths = Dijkstra(graph, 0);
SolutionVisual(pathsLengths);
*/
