using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck04_siomomi_GTron_KGCTron_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(4, "Karn, the Great Creator"),(2, "Ugin, the Spirit Dragon"),(1, "Emrakul, the Promised End"),(2, "Thragtusk"),(2, "Ulamog, the Ceaseless Hunger"),(4, "Wurmcoil Engine"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(3, "Oblivion Stone"),(1, "Blast Zone"),(4, "Forest"),(1, "Sanctum of Ugin"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Crucible of Worlds"),(2, "Dismember"),(1, "Ensnaring Bridge"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(1, "Nature's Claim"),(1, "Sorcerous Spyglass"),(1, "Sundering Titan"),(2, "Surgical Extraction"),(2, "Veil of Summer"),(1, "Weather the Storm"),(1, "Wilt") }; } }
    }
}