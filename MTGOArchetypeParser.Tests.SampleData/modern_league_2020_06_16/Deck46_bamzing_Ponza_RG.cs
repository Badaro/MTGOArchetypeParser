using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck46_bamzing_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(3, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(3, "Pillage"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(1, "Misty Rainforest"),(6, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(4, "Stomping Ground"),(4, "Verdant Catacombs"),(1, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Boil"),(2, "Cindervines"),(2, "Collector Ouphe"),(1, "Grafdigger's Cage"),(2, "Kitchen Finks"),(2, "Obstinate Baloth"),(2, "Relic of Progenitus") }; } }
    }
}