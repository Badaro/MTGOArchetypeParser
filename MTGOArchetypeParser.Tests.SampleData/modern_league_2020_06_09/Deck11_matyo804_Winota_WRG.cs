using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck11_matyo804_Winota_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Angrath's Marauders"),(4, "Arbor Elf"),(4, "Birds of Paradise"),(1, "Magus of the Moon"),(4, "Seasoned Pyromancer"),(4, "Strangleroot Geist"),(3, "Voice of Resurgence"),(4, "Winota, Joiner of Forces"),(4, "Eldritch Evolution"),(4, "Lightning Bolt"),(2, "Smuggler's Copter"),(1, "Arid Mesa"),(1, "Cavern of Souls"),(4, "Copperline Gorge"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(3, "Stomping Ground"),(3, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Choke"),(1, "Collector Ouphe"),(1, "Damping Sphere"),(1, "Gaddock Teeg"),(2, "Knight of Autumn"),(1, "Linvala, Keeper of Silence"),(1, "Nullhide Ferox"),(2, "Obstinate Baloth"),(2, "Path to Exile"),(2, "Relic of Progenitus"),(1, "Veil of Summer") }; } }
    }
}