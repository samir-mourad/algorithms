using Algorithms.Sort;

namespace Algorithms.Tests.Sort
{
    public class QuickSortTest
    {
        [Fact]
        public void SortTest()
        {
            var collection = new int[] { 5, 3, 8, 4, 2, 7, 1, 6 };
            var quickSort = new QuickSort();

            var sortedCollection = quickSort.Sort(collection);
            var expectedCollection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.Equal(expectedCollection, sortedCollection);
        }
    }
}
