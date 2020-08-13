using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck64_Qernavak_DiceFactoryTron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Coretapper"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(2, "All Is Dust"),
            new SampleCard(3, "Astral Cornucopia"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Everflowing Chalice"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(4, "Mazemind Tome"),
            new SampleCard(4, "Mystic Forge"),
            new SampleCard(2, "Paradox Engine"),
            new SampleCard(4, "Serum Powder"),
            new SampleCard(4, "Surge Node"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Buried Ruin"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(3, "Inventors' Fair"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Paradox Engine"),
            new SampleCard(1, "Aetherflux Reservoir"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Platinum Emperion"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(1, "Tormod's Crypt") 
        };
    }
}