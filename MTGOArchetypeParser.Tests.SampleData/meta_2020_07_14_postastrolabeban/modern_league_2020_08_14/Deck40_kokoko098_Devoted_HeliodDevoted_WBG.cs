using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck40_kokoko098_Devoted_HeliodDevoted_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Noble Hierarch"),
            new SampleCard(3, "Ranger-Captain of Eos"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(1, "Viscera Seer"),
            new SampleCard(3, "Vizier of Remedies"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Finale of Devastation"),
            new SampleCard(1, "Chord of Calling"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(2, "Plains"),
            new SampleCard(2, "Razorverge Thicket"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Auriok Champion"),
            new SampleCard(1, "Choke"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}