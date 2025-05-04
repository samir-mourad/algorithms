namespace Algorithms.Search
{
    public class Dijkstra
    {
        public KeyValuePair<string, int> Execute(Dictionary<string, Dictionary<string, int>> graph, string start, string end)
        {
            var costs = graph.Keys.ToDictionary(node => node, node => int.MaxValue);
            costs[start] = 0;

            var parents = new Dictionary<string, string?> { [start] = null };
            var processed = new HashSet<string>();

            var node = FindLowestCostNode(costs, processed);

            while (node != null)
            {
                int cost = costs[node];
                foreach (var neighbor in graph[node])
                {
                    int newCost = cost + neighbor.Value;
                    if (newCost < costs[neighbor.Key])
                    {
                        costs[neighbor.Key] = newCost;
                        parents[neighbor.Key] = node;
                    }
                }
                processed.Add(node);
                node = FindLowestCostNode(costs, processed);
            }

            var path = new List<string>();
            var current = end;

            while (current != null)
            {
                path.Insert(0, current);
                parents.TryGetValue(current, out current);
            }

            return new KeyValuePair<string, int>(string.Join(" -> ", path), costs[end]);
        }

        static string? FindLowestCostNode(Dictionary<string, int> costs, HashSet<string> processed)
        {
            int lowestCost = int.MaxValue;
            string? lowestCostNode = null;

            foreach (var node in costs)
            {
                if (node.Value < lowestCost && !processed.Contains(node.Key))
                {
                    lowestCost = node.Value;
                    lowestCostNode = node.Key;
                }
            }

            return lowestCostNode;
        }
    }
}
