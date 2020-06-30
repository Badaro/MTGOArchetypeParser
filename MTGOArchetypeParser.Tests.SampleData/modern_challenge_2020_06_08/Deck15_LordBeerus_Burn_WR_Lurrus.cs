using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck15_LordBeerus_Burn_WR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(3, "Lightning Helix"),(4, "Searing Blaze"),(1, "Skullcrack"),(4, "Arid Mesa"),(4, "Inspiring Vantage"),(2, "Sacred Foundry"),(3, "Scalding Tarn"),(3, "Snow-Covered Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Skullcrack"),(2, "Kor Firewalker"),(1, "Lurrus of the Dream Den"),(3, "Path to Exile"),(3, "Rest in Peace"),(3, "Smash to Smithereens") }; } }
    }
}