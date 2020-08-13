using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck45_lopi_HeliodCombo_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anafenza, Kin-Tree Spirit"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Conclave Mentor"),
            new SampleCard(2, "Grand Abolisher"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Brushland"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}