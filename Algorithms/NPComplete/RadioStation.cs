namespace Algorithms.NPComplete
{
    public class RadioStation
    {
        public HashSet<string> Find(Dictionary<string, HashSet<string>> stations, HashSet<string> states)
        {
            var finalStations = new HashSet<string>();

            while (states.Any())
            {
                var bestStation = String.Empty;
                var statesCovered = new HashSet<string>();
                
                foreach (var station in stations)
                {
                    var covered = new HashSet<string>(station.Value);
                    covered.IntersectWith(states);
                    
                    if (covered.Count > statesCovered.Count)
                    {
                        bestStation = station.Key;
                        statesCovered = covered;
                    }
                }

                states.RemoveWhere(x => statesCovered.Contains(x));
                finalStations.Add(bestStation);
            }

            return finalStations;
        }
    }
}
