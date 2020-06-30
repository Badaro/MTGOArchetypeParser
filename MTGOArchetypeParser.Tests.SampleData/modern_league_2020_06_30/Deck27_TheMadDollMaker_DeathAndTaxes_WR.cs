using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck27_TheMadDollMaker_DeathAndTaxes_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blade Splicer"),
            new SampleCard(1, "Charming Prince"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(2, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(1, "Remorseful Cleric"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Thalia, Heretic Cathar"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(1, "Inspiring Vantage"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(8, "Snow-Covered Plains"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(1, "Tomik, Distinguished Advokist"),
            new SampleCard(1, "Winds of Abandon") 
        };
    }
}