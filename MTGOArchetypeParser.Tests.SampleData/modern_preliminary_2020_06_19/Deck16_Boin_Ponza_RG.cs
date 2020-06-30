using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck16_Boin_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Seasoned Pyromancer"),(4, "Pillage"),(4, "Lightning Bolt"),(4, "Blood Moon"),(4, "Utopia Sprawl"),(6, "Snow-Covered Forest"),(2, "Snow-Covered Mountain"),(4, "Stomping Ground"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Chandra, Torch of Defiance"),(2, "Abrade"),(1, "Anger of the Gods"),(3, "Boil"),(2, "Cindervines"),(2, "Obstinate Baloth"),(4, "Relic of Progenitus") }; } }
    }
}