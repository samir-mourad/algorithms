namespace Algorithms.Sort
{
    public class SelectionSort
    {
        private readonly int[] _collection = Array.Empty<int>();

        public SelectionSort(int[] collection)
        {
            _collection = collection;
        }

        public int[] Sort()
        {
            for (int i = 0; i < _collection.Length - 1; i++)
            {
                var minIndex = i;

                for (int j = i + 1; j < _collection.Length; j++)
                {
                    if (_collection[j] < _collection[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var temp = _collection[i];
                    _collection[i] = _collection[minIndex];
                    _collection[minIndex] = temp;
                }
            }
            return _collection;
        }
    }
}
