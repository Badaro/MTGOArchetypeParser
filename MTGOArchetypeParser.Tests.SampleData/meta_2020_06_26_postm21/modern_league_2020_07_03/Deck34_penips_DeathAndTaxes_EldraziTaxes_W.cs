using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_03
{
    public class Deck34_penips_DeathAndTaxes_EldraziTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Shefet Dunes"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(9, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(3, "Mirran Crusader"),
            new SampleCard(2, "On Thin Ice"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Stony Silence") 
        };
    }
}