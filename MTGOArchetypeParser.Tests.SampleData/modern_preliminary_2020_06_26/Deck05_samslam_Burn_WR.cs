using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_26
{
    public class Deck05_samslam_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(3, "Searing Blaze"),(2, "Skullcrack"),(3, "Bloodstained Mire"),(3, "Inspiring Vantage"),(3, "Mountain"),(3, "Sacred Foundry"),(4, "Sunbaked Canyon"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Skullcrack"),(1, "Exquisite Firecraft"),(3, "Kor Firewalker"),(3, "Path to Exile"),(3, "Rest in Peace"),(2, "Smash to Smithereens"),(1, "Wear // Tear") }; } }
    }
}