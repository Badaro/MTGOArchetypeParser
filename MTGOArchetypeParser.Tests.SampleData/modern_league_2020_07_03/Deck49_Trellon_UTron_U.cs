using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03
{
    public class Deck49_Trellon_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Karn, Scion of Urza"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(3, "Talisman of Dominance"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
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
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Emrakul, the Promised End"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(3, "Torpor Orb"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}