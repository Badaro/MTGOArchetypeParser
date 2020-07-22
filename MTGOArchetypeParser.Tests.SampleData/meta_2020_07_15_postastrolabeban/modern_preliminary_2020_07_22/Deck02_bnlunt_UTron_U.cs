using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_22
{
    public class Deck02_bnlunt_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Treasure Mage"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Tectonic Edge"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(1, "Tormod's Crypt") 
        };
    }
}