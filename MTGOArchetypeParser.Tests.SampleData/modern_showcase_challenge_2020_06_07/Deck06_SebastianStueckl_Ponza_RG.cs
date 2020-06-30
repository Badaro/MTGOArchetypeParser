using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck06_SebastianStueckl_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Chandra, Torch of Defiance"),(1, "Domri, Anarch of Bolas"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(2, "Glorybringer"),(2, "Hexdrinker"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(2, "Misty Rainforest"),(6, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(4, "Stomping Ground"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Choke"),(2, "Cindervines"),(2, "Collector Ouphe"),(2, "Grafdigger's Cage"),(1, "Obstinate Baloth"),(2, "Pillage"),(2, "Relic of Progenitus"),(2, "Veil of Summer") }; } }
    }
}