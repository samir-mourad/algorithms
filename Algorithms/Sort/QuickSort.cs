namespace Algorithms.Sort
{
    public class QuickSort
    {
        public int[] Sort(int[] collection)
        {
            if (collection.Length <= 1)
                return collection;

            var pivot = collection[collection.Length / 2];

            var left = collection.Where(x => x < pivot).ToArray();
            var right = collection.Where(x => x > pivot).ToArray();

            return Sort(left)
                .Append(pivot)
                .Concat(Sort(right))
                .ToArray();
        }
    }
}
