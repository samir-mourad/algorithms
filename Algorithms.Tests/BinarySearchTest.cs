namespace Algorithms.Tests
{
    public class BinarySearchTest
    {
        private readonly int[] intCollection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private readonly string[] stringCollection = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };


        [Fact]
        public void SearchNumberFive()
        {
            var binarySearch = new BinarySearch(intCollection);

            var indexPositionExpected = 4;
            var indexPosition = binarySearch.Search(5);

            Assert.Equal(indexPositionExpected, indexPosition);
        }

        [Fact]
        public void SearchNumberEleven()
        {
            var binarySearch = new BinarySearch(intCollection);
            var indexPositionExpected = -1;
            var indexPosition = binarySearch.Search(11);

            Assert.Equal(indexPositionExpected, indexPosition);
        }

        [Fact]
        public void SearchLetterB()
        {
            var binarySearch = new BinarySearch(stringCollection);

            var indexPositionExpected = 1;
            var indexPosition = binarySearch.Search("B");

            Assert.Equal(indexPositionExpected, indexPosition);

        }

        [Fact]
        public void SearchLetterZ()
        {
            var binarySearch = new BinarySearch(stringCollection);

            var indexPositionExpected = -1;
            var indexPosition = binarySearch.Search("Z");

            Assert.Equal(indexPositionExpected, indexPosition);
        }
    }
}
