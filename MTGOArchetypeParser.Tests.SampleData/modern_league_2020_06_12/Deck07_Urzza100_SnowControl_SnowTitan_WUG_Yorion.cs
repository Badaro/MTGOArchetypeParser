using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck07_Urzza100_SnowControl_SnowTitan_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(2, "Primeval Titan"),(4, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(3, "Force of Negation"),(4, "Growth Spiral"),(2, "Mana Leak"),(4, "Path to Exile"),(2, "Remand"),(4, "Arcum's Astrolabe"),(3, "Abundant Growth"),(2, "Breeding Pool"),(2, "Field of Ruin"),(3, "Field of the Dead"),(4, "Flooded Strand"),(1, "Glacial Fortress"),(1, "Hallowed Fountain"),(1, "Hinterland Harbor"),(1, "Island"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(1, "Prairie Stream"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(1, "Ashiok, Dream Render"),(1, "Celestial Purge"),(1, "Disdainful Stroke"),(1, "Mystical Dispute"),(1, "On Thin Ice"),(2, "Spreading Seas"),(2, "Timely Reinforcements"),(1, "Veil of Summer"),(2, "Weather the Storm"),(1, "Yorion, Sky Nomad") }; } }
    }
}