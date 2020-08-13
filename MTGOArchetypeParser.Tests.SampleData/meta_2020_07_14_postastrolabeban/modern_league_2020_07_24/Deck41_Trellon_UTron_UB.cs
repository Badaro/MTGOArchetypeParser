using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck41_Trellon_UTron_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Myr Battlesphere"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Treasure Mage"),
            new SampleCard(1, "Trinket Mage"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mazemind Tome"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(5, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(1, "River of Tears"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(3, "Spreading Seas"),
            new SampleCard(1, "Tormod's Crypt") 
        };
    }
}