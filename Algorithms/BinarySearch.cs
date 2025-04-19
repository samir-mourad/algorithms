namespace Algorithms
{
    public class BinarySearch
    {
        private readonly int[] _intCollection = Array.Empty<int>();
        private readonly string[] _stringCollection = Array.Empty<string>();

        public BinarySearch(int[] intCollection)
        {
            _intCollection = intCollection;
        }

        public BinarySearch(string[] stringCollection)
        {
            _stringCollection = stringCollection;
        }

        public int Search(int element)
        {
            var start = 0;
            var end = _intCollection.Length - 1;

            while (start <= end)
            {
                var middle = (start + end) / 2;

                if (_intCollection[middle] < element)
                {
                    start = middle + 1;
                }
                else if (_intCollection[middle] > element)
                {
                    end = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        public int Search(string element)
        {
            var start = 0;
            var end = _stringCollection.Length - 1;

            while (start <= end)
            {
                var middle = (start + end) / 2;

                if (_stringCollection[middle].CompareTo(element) < 0)
                {
                    start = middle + 1;
                }
                else if (_stringCollection[middle].CompareTo(element) > 0)
                {
                    end = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}
