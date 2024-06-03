namespace SortingAlgorithms
{
  public static class SortingAlgorithms
  {
    /// <summary>
    /// Sorts an array using the Bubble Sort algorithm.
    /// </summary>
    /// <typeparam name="T">The type of elements in the array, which must implement IComparable<T>.</typeparam>
    /// <param name="array">The array to be sorted.</param>
    /// <precondition>The input array must not be null.</precondition>
    /// <postcondition>The elements in the input array will be sorted in ascending order.</postcondition>
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
      int[] intTwoArray = [];

      Console.WriteLine("Before sorting:");
      Console.WriteLine(string.Join(", ", intArray));
      Console.WriteLine(string.Join(", ", stringArray));

      SortingAlgorithms.BubbleSort(intArray);
      SortingAlgorithms.BubbleSort(stringArray);
      SortingAlgorithms.BubbleSort(intTwoArray);

      Console.WriteLine("After sorting:");
      Console.WriteLine(string.Join(", ", intArray));
      Console.WriteLine(string.Join(", ", stringArray));
    }
  }
}