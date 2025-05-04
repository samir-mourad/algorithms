using Algorithms.NPComplete;

namespace Algorithms.Tests.NPComplete
{
    public class RadioStationTest
    {
        [Fact]
        public void TestFind()
        {
            var stations = new Dictionary<string, HashSet<string>>
            {
                { "R1", new HashSet<string> { "SP", "RJ", "MG" } },
                { "R2", new HashSet<string> { "RS", "SC", "PR", "SP" } },
                { "R3", new HashSet<string> { "BA", "SE", "AL", "MG" } },
                { "R4", new HashSet<string> { "PE", "PB", "RN", "CE" } },
                { "R5", new HashSet<string> { "CE", "PI", "MA", "TO" } },
                { "R6", new HashSet<string> { "AM", "RR", "RO", "PA" } },
                { "R7", new HashSet<string> { "PA", "AP", "TO", "MA" } },
                { "R8", new HashSet<string> { "MT", "MS", "GO", "DF" } },
                { "R9", new HashSet<string> { "DF", "GO", "MG", "SP" } },
                { "R10", new HashSet<string> { "AC", "RO", "AM", "RR" } },
                { "R11", new HashSet<string> { "ES", "RJ", "BA", "MG" } },
                { "R12", new HashSet<string> { "SP", "PR", "MS", "MT" } },
                { "R13", new HashSet<string> { "PI", "MA", "CE", "RN" } },
                { "R14", new HashSet<string> { "PE", "AL", "SE", "PB" } },
                { "R15", new HashSet<string> { "AP", "PA", "AM", "RR" } },
                { "R16", new HashSet<string> { "PA", "MA", "TO", "GO" } },
                { "R17", new HashSet<string> { "SC", "RS", "MS", "MT" } },
                { "R18", new HashSet<string> { "DF", "GO", "ES", "MG" } },
                { "R19", new HashSet<string> { "AC", "AM", "PA", "TO" } },
                { "R20", new HashSet<string> { "RN", "PB", "CE", "PI" } }
            };
            
            var states = new HashSet<string>
            {
                "SP", "RJ", "MG", "GO", "DF", "BA", "AL", "SE",
                "RS", "SC", "PR", "PA", "MA", "AM", "AC", "RO", "TO", "PI", "RN"
            };

            var radioStation = new RadioStation();
            var result = radioStation.Find(stations, states);

            Assert.Equal(new HashSet<string> { "R1", "R2", "R3", "R8", "R10", "R13", "R16" }, result);
        }
    }
}
