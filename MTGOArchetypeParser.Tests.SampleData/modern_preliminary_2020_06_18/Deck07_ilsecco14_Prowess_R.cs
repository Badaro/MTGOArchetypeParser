using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck07_ilsecco14_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(4, "Monastery Swiftspear"),(3, "Runaway Steam-Kin"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(2, "Firebolt"),(4, "Lava Spike"),(4, "Light Up the Stage"),(2, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Fiery Islet"),(14, "Mountain"),(2, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(3, "Blood Moon"),(2, "Dragon's Claw"),(3, "Grafdigger's Cage"),(2, "Kozilek's Return"),(2, "Shrine of Burning Rage") }; } }
    }
}