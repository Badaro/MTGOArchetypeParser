using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_16
{
    public class Deck09_sinforlife54_DeathAndTaxes_EldraziTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(1, "Thalia, Heretic Cathar"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Eiganjo Castle"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(6, "Plains"),
            new SampleCard(4, "Shefet Dunes"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Leonin Relic-Warder"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Sword of Sinew and Steel"),
            new SampleCard(1, "Winds of Abandon") 
        };
    }
}