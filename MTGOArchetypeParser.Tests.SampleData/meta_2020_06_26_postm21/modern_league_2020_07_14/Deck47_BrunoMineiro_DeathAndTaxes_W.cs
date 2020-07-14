using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck47_BrunoMineiro_DeathAndTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(1, "Restoration Angel"),
            new SampleCard(1, "Stonecloaker"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(10, "Snow-Covered Plains"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(1, "Charming Prince"),
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Ethersworn Canonist"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Tocatli Honor Guard"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}