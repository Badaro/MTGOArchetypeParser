using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck31_ArchaeusDota_GTron_G_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn Liberated"),(2, "Ugin, the Spirit Dragon"),(2, "Conduit of Ruin"),(1, "Emrakul, the Promised End"),(1, "Kozilek, Butcher of Truth"),(4, "Thought-Knot Seer"),(1, "Ulamog, the Ceaseless Hunger"),(1, "World Breaker"),(4, "Wurmcoil Engine"),(1, "All Is Dust"),(4, "Ancient Stirrings"),(4, "Sylvan Scrying"),(4, "Chromatic Sphere"),(4, "Chromatic Star"),(4, "Expedition Map"),(1, "Blast Zone"),(1, "Bonders' Enclave"),(2, "Forest"),(1, "Ghost Quarter"),(1, "Sanctum of Ugin"),(1, "Snow-Covered Forest"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Cavern of Souls"),(2, "Dismember"),(4, "Grafdigger's Cage"),(1, "Jegantha, the Wellspring"),(3, "Leyline of Sanctity"),(1, "Veil of Summer"),(3, "Wilt") }; } }
    }
}