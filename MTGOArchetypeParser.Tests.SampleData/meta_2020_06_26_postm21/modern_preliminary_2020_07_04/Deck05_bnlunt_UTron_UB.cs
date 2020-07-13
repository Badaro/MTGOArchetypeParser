using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_04
{
    public class Deck05_bnlunt_UTron_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mindslaver"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(1, "River of Tears"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}