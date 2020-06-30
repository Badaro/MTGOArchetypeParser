using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck15_haruhilmi24_ETron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Ugin, the Ineffable"),
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Endbringer"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Expedition Map"),
            new SampleCard(1, "Mind Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(2, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(1, "Basilisk Collar"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mystic Forge"),
            new SampleCard(1, "Ratchet Bomb"),
            new SampleCard(1, "Scavenger Grounds"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(3, "Tormod's Crypt"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}