using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck05_indianpancake_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Chandra, Torch of Defiance"),(2, "Wrenn and Six"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Seasoned Pyromancer"),(3, "Pillage"),(1, "Burst Lightning"),(4, "Lightning Bolt"),(4, "Blood Moon"),(4, "Utopia Sprawl"),(4, "Misty Rainforest"),(6, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(4, "Stomping Ground"),(1, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(1, "Boil"),(2, "Choke"),(1, "Cindervines"),(1, "Collector Ouphe"),(1, "Grafdigger's Cage"),(2, "Kitchen Finks"),(2, "Relic of Progenitus"),(1, "Tireless Tracker"),(2, "Veil of Summer") }; } }
    }
}