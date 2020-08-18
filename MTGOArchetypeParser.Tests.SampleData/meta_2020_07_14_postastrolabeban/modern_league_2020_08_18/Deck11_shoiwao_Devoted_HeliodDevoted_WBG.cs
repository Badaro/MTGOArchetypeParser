using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck11_shoiwao_Devoted_HeliodDevoted_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(2, "Duskwatch Recruiter"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(1, "Hexdrinker"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(1, "Sigarda, Host of Herons"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(2, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(2, "Finale of Devastation"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(2, "Eladamri's Call"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Choke"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}