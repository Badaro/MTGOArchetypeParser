using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck53_PuNk_TakingTurns_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(2, "Brazen Borrower"),(4, "Snapcaster Mage"),(4, "Ancestral Vision"),(4, "Temporal Mastery"),(4, "Time Warp"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(4, "Lightning Bolt"),(4, "Opt"),(4, "Remand"),(2, "Spell Snare"),(1, "Flooded Strand"),(6, "Island"),(1, "Mikokoro, Center of the Sea"),(1, "Misty Rainforest"),(1, "Mountain"),(3, "Mystic Sanctuary"),(1, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Steam Vents"),(2, "Sulfur Falls") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Aether Gust"),(1, "Bonecrusher Giant"),(1, "Disdainful Stroke"),(1, "Electrolyze"),(2, "Force of Negation"),(4, "Leyline of Sanctity"),(2, "Pyroclasm"),(2, "Soul-Guide Lantern"),(1, "Teferi, Mage of Zhalfir") }; } }
    }
}