using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck26_Rebus8_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Tidehollow Sculler"),
            new SampleCard(3, "Wasteland Strangler"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Caves of Koilos"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(1, "Leonin Relic-Warder"),
            new SampleCard(1, "Mirran Crusader"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Stony Silence") 
        };
    }
}