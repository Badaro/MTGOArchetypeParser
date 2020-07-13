using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck40_SiDa1991_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Karn, Scion of Urza"),
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Treasure Mage"),
            new SampleCard(1, "Trinket Mage"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(4, "Condescend"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Commandeer"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(2, "Spreading Seas") 
        };
    }
}