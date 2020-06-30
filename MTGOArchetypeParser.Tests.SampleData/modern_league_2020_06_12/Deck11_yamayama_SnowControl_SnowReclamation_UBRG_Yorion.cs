using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck11_yamayama_SnowControl_SnowReclamation_UBRG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(4, "Ice-Fang Coatl"),(2, "Uro, Titan of Nature's Wrath"),(1, "Dead of Winter"),(1, "Abrupt Decay"),(3, "Archmage's Charm"),(4, "Cryptic Command"),(4, "Fact or Fiction"),(3, "Fatal Push"),(2, "Force of Negation"),(4, "Growth Spiral"),(2, "Nexus of Fate"),(4, "Remand"),(4, "Arcum's Astrolabe"),(4, "Abundant Growth"),(4, "Wilderness Reclamation"),(1, "Breeding Pool"),(4, "Flooded Strand"),(1, "Ketria Triome"),(4, "Misty Rainforest"),(4, "Mystic Sanctuary"),(4, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Uro, Titan of Nature's Wrath"),(1, "Abrupt Decay"),(1, "Fatal Push"),(2, "Ashiok, Dream Render"),(3, "Blood Moon"),(1, "Damnation"),(1, "Plague Engineer"),(1, "Ravenous Trap"),(1, "Surgical Extraction"),(2, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}