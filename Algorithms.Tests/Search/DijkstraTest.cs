using Algorithms.Search;

namespace Algorithms.Tests.Search
{
    public class DijkstraTest
    {
        [Fact]
        public void ShouldReturnFastestPath()
        {
            var graph = new Dictionary<string, Dictionary<string, int>>
            {
                { "A", new Dictionary<string, int> { { "B", 1 }, { "C", 4 } } },
                { "B", new Dictionary<string, int> { { "C", 2 }, { "D", 5 } } },
                { "C", new Dictionary<string, int> { { "D", 1 } } },
                { "D", new Dictionary<string, int>() }
            };

            var dijkstra = new Dijkstra();
            var result = dijkstra.Execute(graph, "A", "D");

            Assert.Equal("A -> B -> C -> D", result.Key);
            Assert.Equal(4, result.Value);
        }

        [Fact]
        public void ShouldReturnFastestPath_WithBigGraph()
        {
            var graph = new Dictionary<string, Dictionary<string, int>>
            {
                { "A", new Dictionary<string, int> { { "B", 3 }, { "C", 2 } } },
                { "B", new Dictionary<string, int> { { "D", 4 }, { "E", 2 } } },
                { "C", new Dictionary<string, int> { { "F", 5 }, { "G", 2 } } },
                { "D", new Dictionary<string, int> { { "H", 1 } } },
                { "E", new Dictionary<string, int> { { "H", 6 }, { "I", 3 } } },
                { "F", new Dictionary<string, int> { { "I", 2 }, { "J", 3 } } },
                { "G", new Dictionary<string, int> { { "J", 4 } } },
                { "H", new Dictionary<string, int> { { "K", 3 } } },
                { "I", new Dictionary<string, int> { { "K", 2 }, { "L", 4 } } },
                { "J", new Dictionary<string, int> { { "L", 2 } } },
                { "K", new Dictionary<string, int> { { "M", 1 } } },
                { "L", new Dictionary<string, int> { { "M", 3 }, { "N", 2 } } },
                { "M", new Dictionary<string, int> { { "O", 2 } } },
                { "N", new Dictionary<string, int> { { "O", 3 }, { "P", 4 } } },
                { "O", new Dictionary<string, int> { { "Q", 2 } } },
                { "P", new Dictionary<string, int> { { "Q", 1 } } },
                { "Q", new Dictionary<string, int> { { "R", 2 } } },
                { "R", new Dictionary<string, int> { { "S", 3 } } },
                { "S", new Dictionary<string, int> { { "T", 2 } } },
                { "T", new Dictionary<string, int>() }
            };

            var dijkstra = new Dijkstra();
            var result = dijkstra.Execute(graph, "A", "T");

            Assert.Equal("A -> B -> E -> I -> K -> M -> O -> Q -> R -> S -> T", result.Key);
            Assert.Equal(22, result.Value);
        }
    }
}
