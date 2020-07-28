using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck71_Metcalf23_DeathAndTaxes_WR_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(9, "Plains"),
            new SampleCard(2, "Rugged Prairie"),
            new SampleCard(3, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(2, "Boil"),
            new SampleCard(4, "Burrenton Forge-Tender"),
            new SampleCard(4, "Rest in Peace"),
            new SampleCard(2, "Winds of Abandon"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}