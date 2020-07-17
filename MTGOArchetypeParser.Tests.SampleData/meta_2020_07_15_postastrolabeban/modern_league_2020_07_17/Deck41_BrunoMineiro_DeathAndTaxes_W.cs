using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck41_BrunoMineiro_DeathAndTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gideon of the Trials"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(3, "Phyrexian Revoker"),
            new SampleCard(2, "Selfless Spirit"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(1, "Flagstones of Trokair"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(9, "Snow-Covered Plains"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Ethersworn Canonist"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Settle the Wreckage"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Winds of Abandon") 
        };
    }
}