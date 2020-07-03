using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03
{
    public class Deck22_Nilsfit_Devoted_HeliodDevoted_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Heliod, Sun-Crowned"),
            new SampleCard(1, "Ranger-Captain of Eos"),
            new SampleCard(1, "Spike Feeder"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(2, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Oath of Nissa"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}