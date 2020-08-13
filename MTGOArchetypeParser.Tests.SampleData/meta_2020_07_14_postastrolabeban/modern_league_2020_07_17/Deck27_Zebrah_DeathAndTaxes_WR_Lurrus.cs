using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_17
{
    public class Deck27_Zebrah_DeathAndTaxes_WR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Selfless Savior"),
            new SampleCard(4, "Serra Avenger"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Smuggler's Copter"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(3, "Sacred Foundry"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Boil"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(3, "Tocatli Honor Guard"),
            new SampleCard(1, "Winds of Abandon") 
        };
    }
}