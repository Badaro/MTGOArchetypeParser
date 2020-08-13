using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck42_LordoftheLobsters_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(4, "Condescend"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Repeal"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(3, "Mazemind Tome"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Eldrazi Temple"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Meteor Golem"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}