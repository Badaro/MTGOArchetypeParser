using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck50_MagicDevil666_UTron_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(2, "Condescend"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Gemstone Caverns"),
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
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mazemind Tome"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Trinisphere") 
        };
    }
}