using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck24_Gaffiere1903_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(3, "Glorybringer"),(3, "Klothys, God of Destiny"),(1, "Magus of the Moon"),(1, "Questing Beast"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(4, "Pillage"),(4, "Lightning Bolt"),(2, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Forest"),(1, "Mountain"),(4, "Stomping Ground"),(4, "Verdant Catacombs"),(1, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Choke"),(2, "Cindervines"),(2, "Collector Ouphe"),(1, "Grafdigger's Cage"),(2, "Relic of Progenitus"),(2, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}