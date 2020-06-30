using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck10_otakkun_GTron_KGCTron_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(4, "Karn, the Great Creator"),(2, "Ugin, the Spirit Dragon"),(1, "Kozilek, the Great Distortion"),(1, "Thragtusk"),(2, "Ulamog, the Ceaseless Hunger"),(1, "Walking Ballista"),(3, "Wurmcoil Engine"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(1, "Dismember"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(3, "Oblivion Stone"),(1, "Blast Zone"),(1, "Nurturing Peatland"),(1, "Sanctum of Ugin"),(3, "Snow-Covered Forest"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Thragtusk"),(1, "Walking Ballista"),(1, "Dismember"),(1, "Emrakul, the Promised End"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(2, "Nature's Claim"),(1, "Spatial Contortion"),(1, "Trinisphere"),(2, "Veil of Summer"),(1, "Warping Wail") }; } }
    }
}