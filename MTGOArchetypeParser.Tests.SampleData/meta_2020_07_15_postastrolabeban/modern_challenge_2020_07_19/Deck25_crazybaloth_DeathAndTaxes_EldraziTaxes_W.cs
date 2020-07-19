using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck25_crazybaloth_DeathAndTaxes_EldraziTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Containment Priest"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Restoration Angel"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(2, "Thraben Inspector"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(6, "Plains"),
            new SampleCard(1, "Scavenger Grounds"),
            new SampleCard(2, "Shefet Dunes"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Containment Priest"),
            new SampleCard(1, "Blessed Alliance"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Gideon, Ally of Zendikar"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(1, "Leonin Relic-Warder"),
            new SampleCard(1, "Mirran Crusader"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Settle the Wreckage"),
            new SampleCard(1, "Winds of Abandon"),
            new SampleCard(1, "Wing Shards") 
        };
    }
}