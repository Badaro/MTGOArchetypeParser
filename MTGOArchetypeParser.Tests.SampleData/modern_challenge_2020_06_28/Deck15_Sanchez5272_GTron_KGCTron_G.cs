using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck15_Sanchez5272_GTron_KGCTron_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(4, "Karn, the Great Creator"),(2, "Ugin, the Spirit Dragon"),(2, "Thragtusk"),(2, "Ulamog, the Ceaseless Hunger"),(3, "Wurmcoil Engine"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(2, "Spatial Contortion"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(3, "Oblivion Stone"),(1, "Blast Zone"),(4, "Forest"),(1, "Sanctum of Ugin"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Wurmcoil Engine"),(1, "Oblivion Stone"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(2, "Nature's Claim"),(1, "Pithing Needle"),(1, "Trinisphere"),(2, "Veil of Summer"),(1, "Walking Ballista"),(2, "Weather the Storm"),(1, "Witchbane Orb") }; } }
    }
}