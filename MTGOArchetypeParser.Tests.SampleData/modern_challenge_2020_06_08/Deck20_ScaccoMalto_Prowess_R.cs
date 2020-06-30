using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck20_ScaccoMalto_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bedlam Reveler"),(2, "Kiln Fiend"),(4, "Monastery Swiftspear"),(2, "Runaway Steam-Kin"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Lava Spike"),(4, "Light Up the Stage"),(2, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Fiery Islet"),(14, "Mountain") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(3, "Blood Moon"),(1, "Kozilek's Return"),(1, "Saheeli, Sublime Artificer"),(2, "Shrine of Burning Rage"),(2, "Sorcerous Spyglass"),(3, "Tormod's Crypt") }; } }
    }
}