using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck29_Blademaster777_HammerTime_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Burrenton Forge-Tender"),(4, "Giver of Runes"),(4, "Kor Duelist"),(4, "Kor Outfitter"),(4, "Spellskite"),(4, "Stoneforge Mystic"),(4, "Steelshaper's Gift"),(4, "Magnetic Theft"),(4, "Colossus Hammer"),(1, "Shadowspear"),(4, "Sigarda's Aid"),(1, "Arid Mesa"),(4, "Inkmoth Nexus"),(4, "Inspiring Vantage"),(6, "Plains"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Burrenton Forge-Tender"),(2, "Auriok Champion"),(1, "Damping Sphere"),(3, "Leonin Relic-Warder"),(2, "Lightning Bolt"),(2, "Path to Exile"),(3, "Rest in Peace") }; } }
    }
}