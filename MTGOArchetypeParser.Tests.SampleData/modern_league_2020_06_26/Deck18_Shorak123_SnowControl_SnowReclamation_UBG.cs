using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck18_Shorak123_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(1, "Abrupt Decay"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(3, "Fact or Fiction"),(3, "Fatal Push"),(2, "Force of Negation"),(2, "Mana Leak"),(1, "Nexus of Fate"),(2, "Remand"),(4, "Arcum's Astrolabe"),(3, "Wilderness Reclamation"),(1, "Breeding Pool"),(2, "Flooded Strand"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(3, "Dead of Winter"),(1, "Engineered Explosives"),(2, "Mystical Dispute"),(1, "Notion Thief"),(1, "Sphinx of the Final Word"),(3, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}