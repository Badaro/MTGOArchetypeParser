using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_17
{
    public class Deck24_junghans_HeliodCombo_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Auriok Champion"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Conclave Mentor"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(2, "Eladamri's Call"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(1, "Wooded Bastion"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Hangarback Walker"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Voice of Resurgence") 
        };
    }
}