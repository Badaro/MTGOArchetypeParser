using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck46_mrjgiles_UTron_U : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Karn, Scion of Urza"),(3, "Karn, the Great Creator"),(1, "Ugin, the Spirit Dragon"),(2, "Walking Ballista"),(1, "Wurmcoil Engine"),(4, "Condescend"),(1, "Cyclonic Rift"),(2, "Dismember"),(3, "Remand"),(2, "Repeal"),(4, "Thirst for Knowledge"),(1, "Chalice of the Void"),(4, "Expedition Map"),(1, "Mindslaver"),(4, "Relic of Progenitus"),(2, "Talisman of Dominance"),(1, "Academy Ruins"),(1, "Blast Zone"),(1, "Field of Ruin"),(2, "Gemstone Caverns"),(6, "Snow-Covered Island"),(1, "Tolaria West"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "Wurmcoil Engine"),(2, "Chalice of the Void"),(3, "Aether Gust"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Pithing Needle"),(1, "Spell Snare"),(2, "Spreading Seas"),(1, "Sundering Titan"),(1, "Trinisphere") }; } }
    }
}