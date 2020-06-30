using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck30_Kaipa_Burn_WR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(4, "Mishra's Bauble"),(1, "Seal of Fire"),(2, "Arid Mesa"),(2, "Bloodstained Mire"),(2, "Fiery Islet"),(4, "Inspiring Vantage"),(2, "Mountain"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Kor Firewalker"),(1, "Lurrus of the Dream Den"),(3, "Path to Exile"),(3, "Searing Blaze"),(2, "Searing Blood"),(3, "Wear // Tear") }; } }
    }
}