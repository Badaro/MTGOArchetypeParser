using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_21
{
    public class Deck14_RicardoMSLan_GTron_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(1, "Ugin, the Ineffable"),
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(2, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(1, "World Breaker"),
            new SampleCard(3, "Wurmcoil Engine"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Oblivion Stone"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(1, "Scattered Groves"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Emrakul, the Aeons Torn"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Warping Wail") 
        };
    }
}