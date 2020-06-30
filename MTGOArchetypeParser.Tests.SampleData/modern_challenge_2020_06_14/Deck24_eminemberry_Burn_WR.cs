using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck24_eminemberry_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(2, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(3, "Lightning Helix"),(3, "Searing Blaze"),(4, "Skullcrack"),(2, "Arid Mesa"),(1, "Bloodstained Mire"),(2, "Fiery Islet"),(4, "Inspiring Vantage"),(3, "Mountain"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Searing Blaze"),(1, "Angel's Grace"),(1, "Deflecting Palm"),(2, "Kor Firewalker"),(2, "Path to Exile"),(2, "Rest in Peace"),(1, "Searing Blood"),(3, "Smash to Smithereens"),(2, "Wear // Tear") }; } }
    }
}