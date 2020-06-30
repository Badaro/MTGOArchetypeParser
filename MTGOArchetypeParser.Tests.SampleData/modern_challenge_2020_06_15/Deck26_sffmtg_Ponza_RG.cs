using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck26_sffmtg_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(2, "Wrenn and Six"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(1, "Bonecrusher Giant"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(2, "Magus of the Moon"),(3, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(4, "Lightning Bolt"),(2, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(4, "Stomping Ground"),(2, "Verdant Catacombs"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Anger of the Gods"),(2, "Choke"),(3, "Collector Ouphe"),(2, "Grafdigger's Cage"),(1, "Pillage"),(2, "Relic of Progenitus"),(2, "Unravel the Aether"),(2, "Weather the Storm") }; } }
    }
}