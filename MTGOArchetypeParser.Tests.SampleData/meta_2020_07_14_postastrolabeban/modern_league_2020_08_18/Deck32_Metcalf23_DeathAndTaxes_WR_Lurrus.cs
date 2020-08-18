using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck32_Metcalf23_DeathAndTaxes_WR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dire Fleet Daredevil"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Selfless Savior"),
            new SampleCard(4, "Serra Avenger"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(1, "Eiganjo Castle"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Plains"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Tocatli Honor Guard"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}