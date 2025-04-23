using Algorithms.Search;

namespace Algorithms.Tests.Search
{
    public class BFSTest
    {
        [Fact]
        public void SearchGuitarSeller()
        {
            var alice = new Person("Alice");
            var bob = new Person("Bob");
            var carol = new Person("Carol");
            var daniel = new Person("Daniel");
            var emily = new Person("Emily", SellsGuitars: true);
            var frank = new Person("Frank");
            var grace = new Person("Grace");
            var helen = new Person("Helen");
            var ian = new Person("Ian");
            var julia = new Person("Julia");
            var kevin = new Person("Kevin");
            var laura = new Person("Laura");
            var mike = new Person("Mike", SellsGuitars: true);
            var nina = new Person("Nina");
            var oscar = new Person("Oscar");
            var paula = new Person("Paula");
            var quentin = new Person("Quentin");
            var rachel = new Person("Rachel");
            var sam = new Person("Sam");
            var tina = new Person("Tina");
            var ursula = new Person("Ursula");
            var victor = new Person("Victor");
            var wendy = new Person("Wendy");
            var xavier = new Person("Xavier");
            var yolanda = new Person("Yolanda");

            alice.Friends.AddRange([bob, carol, daniel]);
            bob.Friends.AddRange([emily, frank]);
            carol.Friends.AddRange([grace, helen]);
            daniel.Friends.AddRange([ian, julia]);
            frank.Friends.AddRange([kevin, laura]);
            grace.Friends.AddRange([mike, nina]);
            helen.Friends.AddRange([oscar]);
            ian.Friends.AddRange([paula]);
            julia.Friends.AddRange([quentin]);
            kevin.Friends.AddRange([rachel]);
            laura.Friends.AddRange([sam]);
            nina.Friends.AddRange([tina]);
            oscar.Friends.AddRange([ursula]);
            paula.Friends.AddRange([victor]);
            quentin.Friends.AddRange([wendy]);
            rachel.Friends.AddRange([xavier]);
            sam.Friends.AddRange([yolanda]);


            var bfs = new BFS();
            var result = bfs.Search(alice);

            Assert.Equal("Emily", result);
        }

        [Fact]
        public void SearchNoSellers()
        {
            var alice = new Person("Alice");
            var bob = new Person("Bob");
            var carol = new Person("Carol");
            var daniel = new Person("Daniel");
            var emily = new Person("Emily");
            var frank = new Person("Frank");
            var grace = new Person("Grace");
            var helen = new Person("Helen");
            var ian = new Person("Ian");
            var julia = new Person("Julia");

            alice.Friends.AddRange([bob, carol, daniel]);
            bob.Friends.AddRange([emily, frank]);
            carol.Friends.AddRange([grace, helen]);
            daniel.Friends.AddRange([ian, julia]);

            var bfs = new BFS();
            var result = bfs.Search(alice);

            Assert.Equal("Not found", result);
        }
    }
}
