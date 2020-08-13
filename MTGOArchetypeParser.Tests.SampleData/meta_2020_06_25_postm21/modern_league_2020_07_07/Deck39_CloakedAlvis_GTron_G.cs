using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck39_CloakedAlvis_GTron_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(3, "Thragtusk"),
            new SampleCard(2, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(3, "Wurmcoil Engine"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(3, "Oblivion Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Forest"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Orbs of Warding"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(3, "Thought-Knot Seer") 
        };
    }
}