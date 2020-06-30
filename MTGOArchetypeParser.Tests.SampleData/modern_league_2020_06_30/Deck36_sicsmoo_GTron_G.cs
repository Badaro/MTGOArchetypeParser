using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck36_sicsmoo_GTron_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(2, "Ugin, the Spirit Dragon"),(3, "Thragtusk"),(2, "Ulamog, the Ceaseless Hunger"),(3, "Walking Ballista"),(3, "Wurmcoil Engine"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(2, "Dismember"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(3, "Oblivion Stone"),(1, "Blast Zone"),(4, "Forest"),(1, "Sanctum of Ugin"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Kozilek, the Great Distortion"),(2, "Nature's Claim"),(2, "Orbs of Warding"),(4, "Relic of Progenitus"),(3, "Spatial Contortion"),(3, "Thought-Knot Seer") }; } }
    }
}