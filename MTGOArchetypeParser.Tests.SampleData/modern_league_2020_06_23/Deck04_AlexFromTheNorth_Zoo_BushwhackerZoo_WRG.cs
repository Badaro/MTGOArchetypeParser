using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck04_AlexFromTheNorth_Zoo_BushwhackerZoo_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Burning-Tree Emissary"),(3, "Experiment One"),(1, "Ghor-Clan Rampager"),(3, "Goblin Guide"),(3, "Hidden Herbalists"),(2, "Kird Ape"),(4, "Narnam Renegade"),(4, "Reckless Bushwhacker"),(4, "Tarmogoyf"),(4, "Wild Nacatl"),(4, "Atarka's Command"),(4, "Lightning Bolt"),(1, "Rancor"),(3, "Arid Mesa"),(1, "Dryad Arbor"),(1, "Forest"),(1, "Mountain"),(1, "Sacred Foundry"),(2, "Stomping Ground"),(1, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills"),(1, "Tarfire") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(2, "Destructive Revelry"),(2, "Grafdigger's Cage"),(2, "Magus of the Moon"),(3, "Path to Exile"),(2, "Rampaging Ferocidon"),(2, "Tormod's Crypt") }; } }
    }
}