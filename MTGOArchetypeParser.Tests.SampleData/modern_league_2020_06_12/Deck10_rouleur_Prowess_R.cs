using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck10_rouleur_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Bedlam Reveler"),(2, "Bonecrusher Giant"),(4, "Monastery Swiftspear"),(3, "Runaway Steam-Kin"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Lava Spike"),(4, "Light Up the Stage"),(3, "Burst Lightning"),(3, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Fiery Islet"),(14, "Mountain") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(1, "Blood Moon"),(1, "Boil"),(2, "Dismember"),(2, "Dragon's Claw"),(2, "Grafdigger's Cage"),(2, "Kozilek's Return"),(1, "Shrine of Burning Rage"),(2, "Tormod's Crypt") }; } }
    }
}