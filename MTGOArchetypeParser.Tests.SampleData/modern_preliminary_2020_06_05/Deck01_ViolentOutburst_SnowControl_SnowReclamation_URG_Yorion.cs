using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_05
{
    public class Deck01_ViolentOutburst_SnowControl_SnowReclamation_URG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(4, "Archmage's Charm"),(4, "Cryptic Command"),(4, "Fact or Fiction"),(2, "Force of Negation"),(4, "Growth Spiral"),(4, "Lightning Bolt"),(1, "Nexus of Fate"),(4, "Remand"),(2, "Spell Snare"),(4, "Arcum's Astrolabe"),(3, "Abundant Growth"),(4, "Wilderness Reclamation"),(2, "Breeding Pool"),(4, "Flooded Strand"),(1, "Ketria Triome"),(4, "Misty Rainforest"),(4, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Force of Negation"),(2, "Aether Gust"),(3, "Blood Moon"),(2, "Pyroclasm"),(1, "Radiant Flames"),(3, "Veil of Summer"),(1, "Weather the Storm"),(1, "Yorion, Sky Nomad") }; } }
    }
}