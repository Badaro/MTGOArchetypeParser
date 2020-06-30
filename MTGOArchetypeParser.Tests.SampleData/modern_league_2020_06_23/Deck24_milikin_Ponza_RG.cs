using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck24_milikin_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(3, "Bonecrusher Giant"),(3, "Glorybringer"),(3, "Klothys, God of Destiny"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(3, "Pillage"),(4, "Lightning Bolt"),(4, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Forest"),(1, "Mountain"),(4, "Stomping Ground"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Boil"),(2, "Collector Ouphe"),(2, "Grafdigger's Cage"),(2, "Nature's Claim"),(2, "Obstinate Baloth"),(3, "Veil of Summer") }; } }
    }
}