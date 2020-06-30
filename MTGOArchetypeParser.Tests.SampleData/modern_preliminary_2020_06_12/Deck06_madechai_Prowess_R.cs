using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12
{
    public class Deck06_madechai_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(4, "Monastery Swiftspear"),(3, "Runaway Steam-Kin"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(2, "Firebolt"),(4, "Lava Spike"),(4, "Light Up the Stage"),(2, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Fiery Islet"),(14, "Mountain") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(3, "Blood Moon"),(2, "Dismember"),(3, "Dragon's Claw"),(2, "Smash to Smithereens"),(3, "Soul-Guide Lantern") }; } }
    }
}