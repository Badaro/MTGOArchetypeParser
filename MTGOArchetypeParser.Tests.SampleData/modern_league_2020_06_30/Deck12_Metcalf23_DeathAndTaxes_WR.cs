using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck12_Metcalf23_DeathAndTaxes_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Giver of Runes"),(2, "Goblin Cratermaker"),(4, "Leonin Arbiter"),(2, "Phyrexian Revoker"),(2, "Remorseful Cleric"),(2, "Selfless Savior"),(3, "Serra Avenger"),(4, "Thalia, Guardian of Thraben"),(4, "Path to Exile"),(4, "Aether Vial"),(3, "Smuggler's Copter"),(4, "Seal of Fire"),(4, "Field of Ruin"),(4, "Ghost Quarter"),(4, "Inspiring Vantage"),(1, "Mountain"),(3, "Plains"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Remorseful Cleric"),(2, "Boil"),(4, "Burrenton Forge-Tender"),(4, "Hushbringer"),(1, "Lurrus of the Dream-Den"),(2, "Winds of Abandon") }; } }
    }
}