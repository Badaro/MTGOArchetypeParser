using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck15_MadRamon_SnowControl_SnowReclamation_URG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Coiling Oracle"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(4, "Archmage's Charm"),(2, "Burst Lightning"),(3, "Cryptic Command"),(1, "Cyclonic Rift"),(2, "Expansion // Explosion"),(3, "Fact or Fiction"),(3, "Force of Negation"),(4, "Lightning Bolt"),(1, "Nexus of Fate"),(4, "Remand"),(4, "Arcum's Astrolabe"),(1, "Shark Typhoon"),(4, "Wilderness Reclamation"),(2, "Breeding Pool"),(4, "Flooded Strand"),(2, "Ketria Triome"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(3, "Ashiok, Dream Render"),(1, "Fry"),(2, "Mystical Dispute"),(3, "Veil of Summer"),(2, "Weather the Storm"),(1, "Yorion, Sky Nomad") }; } }
    }
}