using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck01_Metcalf23_DeathAndTaxes_WR_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Blade Splicer"),(4, "Flickerwisp"),(4, "Giver of Runes"),(4, "Leonin Arbiter"),(2, "Lurrus of the Dream Den"),(4, "Magus of the Moon"),(2, "Remorseful Cleric"),(4, "Restoration Angel"),(2, "Seasoned Pyromancer"),(4, "Stoneforge Mystic"),(4, "Thalia, Guardian of Thraben"),(4, "Path to Exile"),(4, "Aether Vial"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(4, "Seal of Fire"),(4, "Field of Ruin"),(4, "Ghost Quarter"),(4, "Inspiring Vantage"),(1, "Mountain"),(8, "Plains"),(4, "Sacred Foundry"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Boil"),(4, "Burrenton Forge-Tender"),(2, "Goblin Cratermaker"),(2, "Phyrexian Revoker"),(2, "Rest in Peace"),(2, "Settle the Wreckage"),(1, "Yorion, Sky Nomad") }; } }
    }
}