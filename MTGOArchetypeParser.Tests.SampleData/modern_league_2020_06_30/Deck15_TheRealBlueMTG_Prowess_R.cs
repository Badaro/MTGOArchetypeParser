using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck15_TheRealBlueMTG_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(3, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(2, "Firebolt"),(4, "Lava Spike"),(4, "Light Up the Stage"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Wild Slash"),(2, "Fiery Islet"),(12, "Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(2, "Apostle's Blessing"),(2, "Blood Moon"),(2, "Dragon's Claw"),(1, "Kozilek's Return"),(2, "Shrine of Burning Rage"),(3, "Soul-Guide Lantern") }; } }
    }
}