using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck01_Metcalf23_DeathAndTaxes_WR_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blade Splicer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Lurrus of the Dream Den"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(8, "Plains"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boil"),
            new SampleCard(4, "Burrenton Forge-Tender"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Settle the Wreckage"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}