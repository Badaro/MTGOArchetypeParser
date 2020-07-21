using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck29_Zetii_DeathAndTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(3, "Blade Splicer"),
            new SampleCard(4, "Charming Prince"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(3, "Restoration Angel"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Thalia, Heretic Cathar"),
            new SampleCard(1, "Thraben Inspector"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Eiganjo Castle"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Flagstones of Trokair"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(10, "Plains"),
            new SampleCard(2, "Tectonic Edge") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(2, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Settle the Wreckage") 
        };
    }
}