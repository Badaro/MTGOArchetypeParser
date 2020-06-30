using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck02_Metcalf23_DeathAndTaxes_WG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(3, "Blade Splicer"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(1, "Winds of Abandon"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(5, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(3, "Stirring Wildwood"),
            new SampleCard(4, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Winds of Abandon"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Settle the Wreckage"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}