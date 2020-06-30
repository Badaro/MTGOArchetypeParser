using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck04_FrankBonaparte_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(3, "Glorybringer"),(3, "Klothys, God of Destiny"),(2, "Magus of the Moon"),(1, "Questing Beast"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(3, "Pillage"),(4, "Lightning Bolt"),(2, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Forest"),(2, "Mountain"),(4, "Stomping Ground"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(1, "Boil"),(2, "Choke"),(2, "Cindervines"),(2, "Collector Ouphe"),(2, "Grafdigger's Cage"),(2, "Obstinate Baloth"),(2, "Trinisphere") }; } }
    }
}