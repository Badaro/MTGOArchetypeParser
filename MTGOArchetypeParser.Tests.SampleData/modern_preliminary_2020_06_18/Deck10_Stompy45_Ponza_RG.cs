using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck10_Stompy45_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(1, "Wrenn and Six"),(4, "Arbor Elf"),(1, "Birds of Paradise"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(3, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(2, "Pillage"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(5, "Forest"),(1, "Misty Rainforest"),(2, "Mountain"),(2, "Prismatic Vista"),(3, "Stomping Ground"),(1, "Verdant Catacombs"),(2, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Pillage"),(2, "Boil"),(2, "Cindervines"),(2, "Collector Ouphe"),(3, "Grafdigger's Cage"),(2, "Kitchen Finks"),(2, "Weather the Storm") }; } }
    }
}