using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck03_gazmon48_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(3, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(2, "Firebolt"),(4, "Lava Spike"),(4, "Light Up the Stage"),(2, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(14, "Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(3, "Blood Moon"),(1, "Dragon's Claw"),(1, "Kozilek's Return"),(4, "Leyline of the Void"),(3, "Shrine of Burning Rage") }; } }
    }
}