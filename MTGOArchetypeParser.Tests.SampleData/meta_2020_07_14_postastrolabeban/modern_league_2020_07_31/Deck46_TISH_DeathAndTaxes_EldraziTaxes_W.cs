using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck46_TISH_DeathAndTaxes_EldraziTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blade Splicer"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Restoration Angel"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(6, "Plains"),
            new SampleCard(2, "Shefet Dunes"),
            new SampleCard(4, "Silent Clearing") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Containment Priest"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Gideon, Ally of Zendikar"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Settle the Wreckage") 
        };
    }
}