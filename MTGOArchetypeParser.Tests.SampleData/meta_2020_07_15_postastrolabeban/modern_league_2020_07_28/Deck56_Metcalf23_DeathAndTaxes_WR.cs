using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck56_Metcalf23_DeathAndTaxes_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Plains"),
            new SampleCard(3, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}