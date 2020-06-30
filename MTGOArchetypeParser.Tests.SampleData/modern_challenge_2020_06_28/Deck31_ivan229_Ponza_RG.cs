using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck31_ivan229_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Chandra, Torch of Defiance"),(2, "Wrenn and Six"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(4, "Pillage"),(4, "Lightning Bolt"),(4, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Forest"),(1, "Mountain"),(4, "Stomping Ground"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(1, "Boil"),(2, "Choke"),(2, "Cindervines"),(2, "Collector Ouphe"),(1, "Grafdigger's Cage"),(3, "Obstinate Baloth"),(2, "Relic of Progenitus") }; } }
    }
}