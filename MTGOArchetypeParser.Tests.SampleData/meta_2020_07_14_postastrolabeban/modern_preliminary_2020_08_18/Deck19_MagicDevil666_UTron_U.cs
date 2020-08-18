using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18
{
    public class Deck19_MagicDevil666_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(2, "Condescend"),
            new SampleCard(1, "Cyclonic Rift"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
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
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}