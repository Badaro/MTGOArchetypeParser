using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_24
{
    public class Deck07_2k4mmorton_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bedlam Reveler"),(2, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Lava Spike"),(4, "Light Up the Stage"),(4, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(1, "Fiery Islet"),(13, "Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(2, "Bonecrusher Giant"),(4, "Dragon's Claw"),(1, "Kozilek's Return"),(1, "Shenanigans"),(4, "Surgical Extraction") }; } }
    }
}