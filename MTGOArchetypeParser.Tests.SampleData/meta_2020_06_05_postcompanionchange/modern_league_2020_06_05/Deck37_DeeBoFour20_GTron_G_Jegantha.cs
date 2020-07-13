using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_05
{
    public class Deck37_DeeBoFour20_GTron_G_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Kozilek, Butcher of Truth"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(1, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(3, "Wurmcoil Engine"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(4, "Oblivion Stone"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(5, "Snow-Covered Forest"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Thragtusk"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}