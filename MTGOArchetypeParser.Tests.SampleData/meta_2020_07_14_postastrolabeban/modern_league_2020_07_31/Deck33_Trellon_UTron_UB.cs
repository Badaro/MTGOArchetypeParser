using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck33_Trellon_UTron_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Treasure Mage"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(1, "Fabricate"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(2, "Spatial Contortion"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Field of Ruin"),
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
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Silent Arbiter"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}