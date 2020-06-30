using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck28_renatoaraujo_GTron_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(1, "Ugin, the Ineffable"),(2, "Ugin, the Spirit Dragon"),(2, "Thragtusk"),(2, "Ulamog, the Ceaseless Hunger"),(1, "Walking Ballista"),(2, "Wurmcoil Engine"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(1, "Dismember"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(3, "Oblivion Stone"),(3, "Relic of Progenitus"),(1, "Blast Zone"),(4, "Forest"),(1, "Ghost Quarter"),(1, "Sanctum of Ugin"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Dismember"),(1, "Choke"),(1, "Grafdigger's Cage"),(3, "Nature's Claim"),(2, "Spatial Contortion"),(1, "Sundering Titan"),(2, "Thought-Knot Seer"),(2, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}