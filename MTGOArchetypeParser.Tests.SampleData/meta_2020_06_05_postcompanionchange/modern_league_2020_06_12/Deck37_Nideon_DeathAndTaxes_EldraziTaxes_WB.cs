using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_12
{
    public class Deck37_Nideon_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Charming Prince"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Tidehollow Sculler"),
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
            new SampleCard(1, "Aven Mindcensor"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(1, "Kunoros, Hound of Athreos"),
            new SampleCard(2, "Orzhov Pontiff"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Stony Silence") 
        };
    }
}