using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck07_nolyfe_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(3, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Lava Spike"),(4, "Light Up the Stage"),(2, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Mutagenic Growth"),(14, "Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(2, "Blood Moon"),(1, "Boil"),(1, "Dismember"),(3, "Dragon's Claw"),(1, "Kozilek's Return"),(4, "Soul-Guide Lantern") }; } }
    }
}