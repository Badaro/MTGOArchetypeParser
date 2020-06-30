using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck07_billsive_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Ice-Fang Coatl"),(4, "Uro, Titan of Nature's Wrath"),(1, "Abrupt Decay"),(2, "Archmage's Charm"),(3, "Cryptic Command"),(2, "Fact or Fiction"),(1, "Fatal Push"),(3, "Force of Negation"),(4, "Growth Spiral"),(1, "Nexus of Fate"),(2, "Remand"),(4, "Arcum's Astrolabe"),(4, "Wilderness Reclamation"),(2, "Breeding Pool"),(4, "Flooded Strand"),(4, "Misty Rainforest"),(4, "Mystic Sanctuary"),(2, "Scalding Tarn"),(1, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fact or Fiction"),(1, "Fatal Push"),(2, "Aether Gust"),(1, "Collective Brutality"),(3, "Dead of Winter"),(1, "Mystical Dispute"),(3, "Veil of Summer"),(3, "Weather the Storm") }; } }
    }
}