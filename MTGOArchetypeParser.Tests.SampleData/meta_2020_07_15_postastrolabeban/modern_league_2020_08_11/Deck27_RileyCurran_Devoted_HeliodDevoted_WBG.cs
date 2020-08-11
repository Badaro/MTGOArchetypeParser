using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck27_RileyCurran_Devoted_HeliodDevoted_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(1, "Carrion Feeder"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Ranger-Captain of Eos"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(3, "Vizier of Remedies"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(1, "Finale of Devastation"),
            new SampleCard(1, "Chord of Calling"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Razorverge Thicket"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Auriok Champion"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}