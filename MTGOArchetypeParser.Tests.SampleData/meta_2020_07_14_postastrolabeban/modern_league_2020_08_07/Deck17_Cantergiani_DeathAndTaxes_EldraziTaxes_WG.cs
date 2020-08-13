using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck17_Cantergiani_DeathAndTaxes_EldraziTaxes_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blade Splicer"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(2, "Flickerwisp"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Brushland"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(3, "Razorverge Thicket") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}