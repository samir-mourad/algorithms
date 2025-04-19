using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    public class SelectionSortTest
    {
        [Fact]
        public void SortTest()
        {
            var collection = new int[] { 5, 3, 8, 4, 2, 7, 1, 6 };
            var selectionSort = new SelectionSort(collection);

            var sortedCollection = selectionSort.Sort();
            var expectedCollection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.Equal(expectedCollection, sortedCollection);
        }
    }
}
