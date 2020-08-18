using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck35_rodebo_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Myr Battlesphere"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Treasure Mage"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(2, "Talisman of Dominance"),
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
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Sphinx of the Final Word"),
            new SampleCard(1, "Tectonic Edge"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}