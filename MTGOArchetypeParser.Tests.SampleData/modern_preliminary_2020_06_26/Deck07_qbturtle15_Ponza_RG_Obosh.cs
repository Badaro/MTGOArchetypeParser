using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_26
{
    public class Deck07_qbturtle15_Ponza_RG_Obosh : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Arbor Elf"),(2, "Birds of Paradise"),(4, "Bonecrusher Giant"),(4, "Glorybringer"),(4, "Kitchen Finks"),(3, "Klothys, God of Destiny"),(4, "Seasoned Pyromancer"),(4, "Pillage"),(4, "Lightning Bolt"),(3, "Blood Moon"),(4, "Utopia Sprawl"),(5, "Forest"),(1, "Misty Rainforest"),(2, "Mountain"),(2, "Prismatic Vista"),(4, "Stomping Ground"),(1, "Verdant Catacombs"),(1, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Flame Slash"),(3, "Grafdigger's Cage"),(1, "Life Goes On"),(2, "Molten Rain"),(2, "Natural State"),(1, "Obosh, the Preypiercer"),(2, "Thragtusk"),(2, "Veil of Summer") }; } }
    }
}