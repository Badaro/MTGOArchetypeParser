using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck02_Metcalf23_DeathAndTaxes_WG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Aven Mindcensor"),(3, "Blade Splicer"),(1, "Eternal Witness"),(4, "Flickerwisp"),(4, "Giver of Runes"),(2, "Knight of Autumn"),(4, "Leonin Arbiter"),(4, "Noble Hierarch"),(4, "Restoration Angel"),(3, "Scavenging Ooze"),(4, "Stoneforge Mystic"),(4, "Thalia, Guardian of Thraben"),(1, "Winds of Abandon"),(4, "Path to Exile"),(4, "Aether Vial"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(4, "Field of Ruin"),(1, "Forest"),(4, "Ghost Quarter"),(4, "Horizon Canopy"),(5, "Plains"),(4, "Razorverge Thicket"),(3, "Stirring Wildwood"),(4, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Knight of Autumn"),(1, "Winds of Abandon"),(2, "Burrenton Forge-Tender"),(2, "Collector Ouphe"),(2, "Gaddock Teeg"),(3, "Rest in Peace"),(2, "Settle the Wreckage"),(1, "Yorion, Sky Nomad") }; } }
    }
}