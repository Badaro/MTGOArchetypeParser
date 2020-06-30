using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck21_Metcalf23_DeathAndTaxes_WR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Charming Prince"),(2, "Dire Fleet Daredevil"),(4, "Giver of Runes"),(2, "Goblin Cratermaker"),(4, "Leonin Arbiter"),(3, "Serra Avenger"),(4, "Thalia, Guardian of Thraben"),(4, "Path to Exile"),(4, "Aether Vial"),(3, "Smuggler's Copter"),(4, "Seal of Fire"),(4, "Field of Ruin"),(4, "Ghost Quarter"),(4, "Inspiring Vantage"),(1, "Mountain"),(2, "Plains"),(3, "Sacred Foundry"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Boil"),(4, "Burrenton Forge-Tender"),(2, "Hushbringer"),(1, "Lurrus of the Dream Den"),(2, "Phyrexian Revoker"),(2, "Remorseful Cleric"),(2, "Wear // Tear") }; } }
    }
}