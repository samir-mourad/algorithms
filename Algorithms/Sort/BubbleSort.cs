using System.Globalization;

namespace Algorithms.Sort
{
    public class BubbleSort
    {
        private readonly int[] _collection = Array.Empty<int>();

        public BubbleSort(int[] collection)
        {
            _collection = collection;
        }

        public int[] Sort()
        {
            for (var i = 0; i < _collection.Length; i++)
            {
                for (var j = i + 1; j < _collection.Length; j++)
                {
                    if (_collection[j] < _collection[i])
                    {
                        var temp = _collection[i];
                        _collection[i] = _collection[j];
                        _collection[j] = temp;
                    }
                }
            }

            return _collection;
        }
    }
}
