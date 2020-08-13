using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck12_junghans_HeliodCombo_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(4, "Conclave Mentor"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(3, "Noble Hierarch"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(1, "Wooded Bastion"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Voice of Resurgence") 
        };
    }
}