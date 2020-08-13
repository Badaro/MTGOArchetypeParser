using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_28
{
    public class Deck05_shoktroopa_UTron_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Thought-Knot Seer"),
            new SampleCard(1, "Trinket Mage"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(1, "Fabricate"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(3, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mindslaver"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Trading Post"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(1, "River of Tears"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Thought-Knot Seer"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(3, "Dismember"),
            new SampleCard(1, "Eldrazi Temple"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}