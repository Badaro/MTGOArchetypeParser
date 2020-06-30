using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck27_FuryGarruk_EmeriaTitan_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Deputy of Detention"),(3, "Flickerwisp"),(1, "Golos, Tireless Pilgrim"),(2, "Lone Missionary"),(1, "Reflector Mage"),(1, "Skittering Surveyor"),(4, "Soulherder"),(3, "Sun Titan"),(2, "Venser, Shaper Savant"),(4, "Wall of Omens"),(3, "Watcher for Tomorrow"),(2, "Winds of Abandon"),(1, "Dovin's Veto"),(4, "Ephemerate"),(1, "Ojutai's Command"),(2, "Path to Exile"),(3, "Emeria, the Sky Ruin"),(4, "Field of Ruin"),(4, "Flooded Strand"),(4, "Hallowed Fountain"),(1, "Island"),(5, "Plains"),(3, "Prairie Stream") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Lone Missionary"),(2, "Dovin's Veto"),(3, "Damping Sphere"),(1, "Disdainful Stroke"),(1, "Ghost Quarter"),(1, "Negate"),(2, "Stony Silence"),(3, "Tormod's Crypt") }; } }
    }
}