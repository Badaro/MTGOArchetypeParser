using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck11_sffmtg_GTron_KGCTron_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(4, "Karn, the Great Creator"),(2, "Ugin, the Spirit Dragon"),(2, "Ulamog, the Ceaseless Hunger"),(2, "Walking Ballista"),(3, "Wurmcoil Engine"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(3, "Oblivion Stone"),(1, "Relic of Progenitus"),(1, "Blast Zone"),(5, "Forest"),(1, "Sanctum of Ugin"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Wurmcoil Engine"),(2, "Relic of Progenitus"),(1, "Dismember"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(3, "Nature's Claim"),(1, "Pithing Needle"),(1, "Sundering Titan"),(1, "Warping Wail"),(2, "Weather the Storm") }; } }
    }
}