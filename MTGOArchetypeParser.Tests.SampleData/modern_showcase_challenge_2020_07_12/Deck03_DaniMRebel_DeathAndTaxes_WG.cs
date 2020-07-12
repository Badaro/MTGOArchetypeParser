using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_07_12
{
    public class Deck03_DaniMRebel_DeathAndTaxes_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Charming Prince"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Renegade Rallier"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(1, "Stirring Wildwood"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(1, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Dromoka's Command"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(3, "Soul-Guide Lantern"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}