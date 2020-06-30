using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck36_Piccio36_Winota_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Angrath's Marauders"),(4, "Arbor Elf"),(4, "Birds of Paradise"),(1, "Magus of the Moon"),(1, "Pia and Kiran Nalaar"),(4, "Seasoned Pyromancer"),(4, "Strangleroot Geist"),(3, "Voice of Resurgence"),(4, "Winota, Joiner of Forces"),(4, "Eldritch Evolution"),(4, "Lightning Bolt"),(1, "Smuggler's Copter"),(4, "Copperline Gorge"),(2, "Forest"),(1, "Mountain"),(1, "Plains"),(1, "Sacred Foundry"),(3, "Stomping Ground"),(2, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Avalanche Riders"),(2, "Caustic Caterpillar"),(1, "Damping Sphere"),(1, "Ethersworn Canonist"),(1, "Gaddock Teeg"),(2, "Knight of Autumn"),(1, "Linvala, Keeper of Silence"),(1, "Obstinate Baloth"),(1, "Path to Exile"),(2, "Relic of Progenitus"),(2, "Thrun, the Last Troll") }; } }
    }
}