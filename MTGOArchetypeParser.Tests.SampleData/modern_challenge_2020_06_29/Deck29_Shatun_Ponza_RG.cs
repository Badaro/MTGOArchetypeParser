using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck29_Shatun_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(4, "Arbor Elf"),(1, "Birds of Paradise"),(4, "Bloodbraid Elf"),(1, "Bonecrusher Giant"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(3, "Pillage"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(6, "Forest"),(1, "Mountain"),(4, "Stomping Ground"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Boil"),(2, "Cindervines"),(2, "Collector Ouphe"),(1, "Grafdigger's Cage"),(2, "Obstinate Baloth"),(2, "Relic of Progenitus"),(2, "Veil of Summer") }; } }
    }
}