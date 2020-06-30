using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck18_wambocombo2020_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(2, "Lightning Helix"),(4, "Searing Blaze"),(2, "Skullcrack"),(4, "Arid Mesa"),(2, "Bloodstained Mire"),(1, "Fiery Islet"),(4, "Inspiring Vantage"),(3, "Mountain"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Skullcrack"),(1, "Grafdigger's Cage"),(3, "Kor Firewalker"),(3, "Path to Exile"),(2, "Rest in Peace"),(2, "Smash to Smithereens"),(2, "Wear // Tear") }; } }
    }
}