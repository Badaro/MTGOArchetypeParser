using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck16_Archgaze_Winota_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Angrath's Marauders"),(4, "Arbor Elf"),(4, "Birds of Paradise"),(1, "Magus of the Moon"),(1, "Resolute Blademaster"),(4, "Seasoned Pyromancer"),(4, "Strangleroot Geist"),(3, "Voice of Resurgence"),(4, "Winota, Joiner of Forces"),(4, "Eldritch Evolution"),(4, "Lightning Bolt"),(1, "Smuggler's Copter"),(1, "Arid Mesa"),(4, "Copperline Gorge"),(1, "Sacred Foundry"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(1, "Snow-Covered Plains"),(3, "Stomping Ground"),(2, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Avalanche Riders"),(1, "Choke"),(1, "Collector Ouphe"),(1, "Damping Sphere"),(1, "Gaddock Teeg"),(1, "Klothys, God of Destiny"),(2, "Knight of Autumn"),(1, "Linvala, Keeper of Silence"),(1, "Obstinate Baloth"),(1, "Path to Exile"),(2, "Relic of Progenitus"),(1, "Thrun, the Last Troll"),(1, "Veil of Summer") }; } }
    }
}