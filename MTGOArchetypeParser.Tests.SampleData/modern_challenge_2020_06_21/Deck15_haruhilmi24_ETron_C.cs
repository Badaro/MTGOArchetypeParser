using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck15_haruhilmi24_ETron_C : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(1, "Ugin, the Ineffable"),(1, "Ugin, the Spirit Dragon"),(1, "Endbringer"),(4, "Matter Reshaper"),(4, "Reality Smasher"),(4, "Simian Spirit Guide"),(4, "Thought-Knot Seer"),(3, "Walking Ballista"),(1, "Wurmcoil Engine"),(1, "All Is Dust"),(2, "Dismember"),(4, "Chalice of the Void"),(3, "Expedition Map"),(1, "Mind Stone"),(1, "Blast Zone"),(3, "Cavern of Souls"),(4, "Eldrazi Temple"),(4, "Urza's Mine"),(4, "Urza's Power Plant"),(4, "Urza's Tower"),(2, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(1, "Wurmcoil Engine"),(1, "Basilisk Collar"),(1, "Crucible of Worlds"),(1, "Ensnaring Bridge"),(1, "Ghost Quarter"),(1, "Liquimetal Coating"),(1, "Mystic Forge"),(1, "Ratchet Bomb"),(1, "Scavenger Grounds"),(1, "Sorcerous Spyglass"),(3, "Tormod's Crypt"),(1, "Trinisphere") }; } }
    }
}