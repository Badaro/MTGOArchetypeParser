using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck57_konoyubitomare15_HeliodCombo_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anafenza, Kin-Tree Spirit"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Conclave Mentor"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(3, "Brushland"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Razorverge Thicket"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Deafening Silence"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Remorseful Cleric"),
            new SampleCard(1, "Selfless Spirit"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Voice of Resurgence"),
            new SampleCard(2, "Worship") 
        };
    }
}