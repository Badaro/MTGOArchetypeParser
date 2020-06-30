using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck06_Larry11_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(2, "Wrenn and Six"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Seasoned Pyromancer"),(3, "Pillage"),(4, "Lightning Bolt"),(4, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Forest"),(1, "Misty Rainforest"),(1, "Mountain"),(4, "Stomping Ground"),(2, "Verdant Catacombs"),(2, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Anger of the Gods"),(2, "Boil"),(2, "Cindervines"),(2, "Collector Ouphe"),(1, "Grafdigger's Cage"),(3, "Kitchen Finks"),(2, "Relic of Progenitus"),(2, "Veil of Summer") }; } }
    }
}