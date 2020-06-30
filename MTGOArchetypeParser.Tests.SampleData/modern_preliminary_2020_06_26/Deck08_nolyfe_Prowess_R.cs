using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_26
{
    public class Deck08_nolyfe_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(2, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Lava Spike"),(4, "Light Up the Stage"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Wild Slash"),(4, "Mishra's Bauble"),(13, "Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(3, "Boil"),(1, "Dismember"),(3, "Dragon's Claw"),(2, "Shrine of Burning Rage"),(3, "Soul-Guide Lantern") }; } }
    }
}