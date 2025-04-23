namespace Algorithms.Search
{
    public class BFS
    {
        public string Search(Person start)
        {
            var queue = new Queue<Person>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var person = queue.Dequeue();

                if (person.SellsGuitars)
                {
                    return person.ToString();
                } else
                {
                    foreach (var friend in person.Friends)
                    {
                        queue.Enqueue(friend);
                    }
                }
            }

            return "Not found";
        }
    }

    public record Person(string Name,  bool SellsGuitars = false)
    {
        public List<Person> Friends { get; init; } = new List<Person>();

        public override string ToString()
        {
            return Name;
        }
    }
}
