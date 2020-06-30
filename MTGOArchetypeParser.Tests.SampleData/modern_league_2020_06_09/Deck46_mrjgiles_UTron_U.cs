using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck46_mrjgiles_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Karn, Scion of Urza"),
            new SampleCard(3, "Karn, the Great Creator"),
            new SampleCard(1, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}