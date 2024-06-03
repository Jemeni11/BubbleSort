namespace SortingAlgorithms
{
  public static class SortingAlgorithms
  {
    public static void BubbleSort<T>(T[] array) where T : IComparable<T>
    {
      bool swapped;
      int n = array.Length;

      // Outer loop for passes
      for (int i = 0; i < n - 1; i++)
      {
        swapped = false;

        // Inner loop for each pass
        for (int j = 0; j < n - i - 1; j++)
        {
          // Compare adjacent elements
          if (array[j].CompareTo(array[j + 1]) > 0)
          {
            // Swap if they are in the wrong order
            (array[j + 1], array[j]) = (array[j], array[j + 1]);
            swapped = true;
          }
        }

        // If no elements were swapped, the array is sorted
        if (!swapped)
        {
          break;
        }
      }
    }
  }

  class Program
  {
    static void Main()
    {
      int[] intArray = [5, 3, 8, 4, 2];
      string[] stringArray = ["apple", "orange", "banana", "pear"];

      Console.WriteLine("Before sorting:");
      Console.WriteLine(string.Join(", ", intArray));
      Console.WriteLine(string.Join(", ", stringArray));

      SortingAlgorithms.BubbleSort(intArray);
      SortingAlgorithms.BubbleSort(stringArray);

      Console.WriteLine("After sorting:");
      Console.WriteLine(string.Join(", ", intArray));
      Console.WriteLine(string.Join(", ", stringArray));
    }
  }
}