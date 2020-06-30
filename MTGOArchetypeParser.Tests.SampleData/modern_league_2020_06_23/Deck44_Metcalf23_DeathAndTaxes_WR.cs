using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck44_Metcalf23_DeathAndTaxes_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Flickerwisp"),(4, "Giver of Runes"),(4, "Leonin Arbiter"),(2, "Lurrus of the Dream Den"),(2, "Seasoned Pyromancer"),(4, "Stoneforge Mystic"),(4, "Thalia, Guardian of Thraben"),(3, "Path to Exile"),(4, "Aether Vial"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(4, "Seal of Fire"),(4, "Field of Ruin"),(4, "Ghost Quarter"),(4, "Inspiring Vantage"),(1, "Mountain"),(2, "Plains"),(3, "Sacred Foundry"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Path to Exile"),(2, "Boil"),(3, "Burrenton Forge-Tender"),(2, "Goblin Cratermaker"),(3, "Magus of the Moon"),(3, "Rest in Peace"),(1, "Wear // Tear") }; } }
    }
}