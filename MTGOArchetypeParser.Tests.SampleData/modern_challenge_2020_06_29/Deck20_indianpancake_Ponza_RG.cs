using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck20_indianpancake_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(2, "Wrenn and Six"),(4, "Arbor Elf"),(1, "Birds of Paradise"),(4, "Bloodbraid Elf"),(1, "Bonecrusher Giant"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(1, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(2, "Pillage"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(4, "Misty Rainforest"),(6, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(4, "Stomping Ground"),(1, "Verdant Catacombs"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(1, "Anger of the Gods"),(3, "Boil"),(1, "Chandra, Heart of Fire"),(1, "Cindervines"),(3, "Grafdigger's Cage"),(3, "Kitchen Finks"),(1, "Relic of Progenitus") }; } }
    }
}