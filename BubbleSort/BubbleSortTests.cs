namespace BubbleSortTests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void BubbleSort_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[]? array = null;

            // Act
            SortingAlgorithms.SortingAlgorithms.BubbleSort(array);
        }

        [TestMethod]
        public void BubbleSort_EmptyArray_DoesNotThrow()
        {
            // Arrange
            int[] array = [];

            // Act & Assert (No exception thrown)
            SortingAlgorithms.SortingAlgorithms.BubbleSort(array);
        }

        [TestMethod]
        public void BubbleSort_AlreadySortedArray_DoesNotModify()
        {
            // Arrange
            int[] array = [1, 2, 3, 4, 5];
            int[] expected = [.. array];

            // Act
            SortingAlgorithms.SortingAlgorithms.BubbleSort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BubbleSort_UnsortedArray_SortsCorrectly()
        {
            // Arrange
            int[] array = [5, 3, 8, 4, 2];
            int[] expected = [2, 3, 4, 5, 8];

            // Act
            SortingAlgorithms.SortingAlgorithms.BubbleSort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BubbleSort_StringArray_SortsCorrectly()
        {
            // Arrange
            string[] array = ["apple", "orange", "banana", "pear"];
            string[] expected = ["apple", "banana", "orange", "pear"];

            // Act
            SortingAlgorithms.SortingAlgorithms.BubbleSort(array);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }

    }
}