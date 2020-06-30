using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck10_cfilly4460_GTron_GolosTron_G_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(3, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Golos, Tireless Pilgrim"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(2, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(1, "World Breaker"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Oblivion Stone"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Cascading Cataracts"),
            new SampleCard(4, "Forest"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Thragtusk"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(3, "Thought-Knot Seer"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Warping Wail") 
        };
    }
}