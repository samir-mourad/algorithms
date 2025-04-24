using Algorithms.Sort;

namespace Algorithms.Tests.Sort
{
    public class BubbleSortTest
    {
        [Fact]
        public void Sort()
        {
            int[] unsorted = [5, 3, 8, 4, 2];
            int[] sorted = [2, 3, 4, 5, 8];

            var bubbleSort = new BubbleSort(unsorted);

            var result = bubbleSort.Sort();

            Assert.Equal(sorted, result);
        }
    }
}
