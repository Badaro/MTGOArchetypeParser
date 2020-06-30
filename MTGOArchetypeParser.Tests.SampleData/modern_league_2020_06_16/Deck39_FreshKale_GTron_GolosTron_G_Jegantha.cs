using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck39_FreshKale_GTron_GolosTron_G_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Karn Liberated"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Emrakul, the Promised End"),
            new SampleCard(2, "Golos, Tireless Pilgrim"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(2, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(1, "World Breaker"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Cascading Cataracts"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Warping Wail") 
        };
    }
}